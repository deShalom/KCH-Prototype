using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyManager : MonoBehaviour
{
    //Variables
    [SerializeField]
    private int g_totalgold, g_goldPerMinute, g_goldPMX;
    private int gTimer;
    public int dog = 100;
    public int dog2 = 200;
    public int target = 30;

    void Awake()
    {
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = target;
    }

    //Methods
    public int totalgold
    {
        get { return g_totalgold; }
        set { g_totalgold = value; }
    }

    public int goldperminute
    {
        get { return g_goldPerMinute; }
        set { g_goldPerMinute = value; }
    }

    public int goldpmx
    {
        get { return g_goldPMX; }
        set { g_goldPMX = value; }
    }

    private void Start()
    {
        totalgold = 0;
        goldperminute = 1;
        goldpmx = 0;
    }

    private void Update()
    {
        if (Application.targetFrameRate != target)
        {
            Application.targetFrameRate = target;
        }
    }

    private void FixedUpdate()
    {
        for (float i = 0; i < 60; i++)
        {
            if (i == 5)
            {
                i = 0;
                print("Reached 5 second, cleared.");
                //totalgold = totalgold + goldperminute * g_goldPMX;
                //print(totalgold);
            }
        }
    }
}

//All code written by Jay Underwood (deShalom).
