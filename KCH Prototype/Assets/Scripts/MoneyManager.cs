using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyManager : MonoBehaviour
{
    //Variables
    [SerializeField]
    static private float g_totalgold;
    static private float g_goldPerMinute;
    static private float g_goldPMX;
    static private float gTimer = 10f;
    static public float yTimer = 0.01f;
    static public float cYear = 1060;
    static public int target = 30;

    public Text goldC, yearC, goldPM, goldPMX;
    bool coRunning;

    //Methods    
    void Awake()
    {
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = target;
    }
    static public float totalgold
    {
        get { return g_totalgold; }
        set { g_totalgold = value; }
    }

    static public float goldperminute
    {
        get { return g_goldPerMinute; }
        set { g_goldPerMinute = value; }
    }

     static public float goldpmx
    {
        get { return g_goldPMX; }
        set { g_goldPMX = value; }
    }

    public void Start()
    {
        //Removed for testing (Apply these only when player has swapped between scenes)
       // totalgold = PlayerPrefs.GetFloat("tGold", 0);
       // goldperminute = PlayerPrefs.GetFloat("pmGold", 1);
       // goldpmx = PlayerPrefs.GetFloat("pmxGold", 1);

        totalgold = 500;
        goldperminute = 10;
        goldpmx = 1;

        //Coroutines
        coRunning = true;
        StartCoroutine(yearTicker());
        StartCoroutine(goldTicker());

    }

    public void Update()
    {
        if (Application.targetFrameRate != target)
        {
            Application.targetFrameRate = target;
        }

        //gTimer -= Time.deltaTime;
        //yTimer -= Time.deltaTime;

        //if (gTimer <= 0.0f)
        //{
        //    totalgold += goldperminute;
        //    gTimer += 10f;
        //    print("Fired");
        //}

        //if (yTimer <= 0.0f)
        //{
        //    cYear = cYear += 1f;
        //    yTimer += 2.5f;
        //}

        goldC.text = "Gold: " + totalgold.ToString();
        yearC.text = cYear.ToString();
        goldPM.text = "GPM:" + goldperminute.ToString();
        goldPMX.text = "GPM*:" + goldpmx.ToString();

        PlayerPrefs.SetFloat("tGold", totalgold);
        PlayerPrefs.SetFloat("pmGold", goldperminute);
        PlayerPrefs.SetFloat("pmxGold", goldpmx);
    }

    IEnumerator yearTicker()
    {
        while (coRunning == true)
        {
            yTimer -= Time.fixedDeltaTime;
            if (yTimer <= 0.0f)
            {
                cYear = cYear += 1f;
                yTimer += 0.01f;
            }
            yield return null;
        }
    }

    IEnumerator goldTicker()
    {
        while (coRunning == true)
        {
            gTimer -= Time.fixedDeltaTime;

            if (gTimer <= 0.0f)
            {
                totalgold += goldperminute;
                gTimer += 10f;
            }
            yield return null;
        }
    }

    public void pauseGame()
    {
        coRunning = false;
    }

    public void resumeGame()
    {
        coRunning = true;
        StartCoroutine(yearTicker());
        StartCoroutine(goldTicker());
    }
}
//All code written by Jay Underwood (deShalom).
