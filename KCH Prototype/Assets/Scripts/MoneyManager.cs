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
    static public float yTimer = 2.5f;
    static private float cYear = 1200;
    static public int target = 30;

    public Text goldC, yearC, goldPM, goldPMX;

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
            gTimer += 10f;
        }

        if (yTimer <= 0.0f)
        {
            cYear = cYear += 1f;
            yTimer += 2.5f;
        }

        goldC.text = "Gold: " + totalgold.ToString();
        yearC.text = "Year: " + cYear.ToString();
        goldPM.text = "GPM:" + goldperminute.ToString();
        goldPMX.text = "GPM*:" + goldpmx.ToString();

        PlayerPrefs.SetFloat("tGold", totalgold);
        PlayerPrefs.SetFloat("pmGold", goldperminute);
        PlayerPrefs.SetFloat("pmxGold", goldpmx);
    }
}
//All code written by Jay Underwood (deShalom).
