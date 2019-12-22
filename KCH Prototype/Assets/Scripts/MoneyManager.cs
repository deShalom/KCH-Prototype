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
    //Change to private after debugging
    static private float gTimer = 60;
    static public float yTimer = 30;
    static private float cYear = 0;
    static public int target = 30;

    public Text goldC, yearC;

    //Methods    
    void Awake()
    {
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = target;
    }
    public float totalgold
    {
        get { return g_totalgold; }
        set { g_totalgold = value; }
    }

    public float goldperminute
    {
        get { return g_goldPerMinute; }
        set { g_goldPerMinute = value; }
    }

    public float goldpmx
    {
        get { return g_goldPMX; }
        set { g_goldPMX = value; }
    }

    public void Start()
    {
        //Needs removing or it'll reset on every scene change, PlayerPrefs?
        totalgold = PlayerPrefs.GetFloat("tGold", 0);
        goldperminute = PlayerPrefs.GetFloat("pmGold", 1);
        goldpmx = PlayerPrefs.GetFloat("pmxGold", 1);
    }

    public void Update()
    {
        if (Application.targetFrameRate != target)
        {
            Application.targetFrameRate = target;
        }

        gTimer -= Time.deltaTime;
        yTimer -= Time.deltaTime;

        if (gTimer <= 0.0f)
        {
            totalgold = totalgold + goldperminute * g_goldPMX;
            gTimer += 60f;
        }

        if (yTimer <= 0.0f)
        {
            cYear = cYear += 100f;
            yTimer += 60f;
        }

        goldC.text = "Gold: " + totalgold.ToString();
        yearC.text = "Year: " + cYear.ToString();

        PlayerPrefs.SetFloat("tGold", totalgold);
        PlayerPrefs.SetFloat("pmGold", goldperminute);
        PlayerPrefs.SetFloat("pmxGold", goldpmx);
    }
}
//All code written by Jay Underwood (deShalom).
