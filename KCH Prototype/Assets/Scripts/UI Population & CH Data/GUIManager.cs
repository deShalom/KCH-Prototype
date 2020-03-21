using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GUIManager : MonoBehaviour
{
    //Variables
    public GameObject monPnl, conPnl, wcPnl, mhPnl, urPnl, stPnl, baPnl, ccPnl, lcPnl, apPnl, fbPnl;
    public Button mon1Btn, tvBtn, wcBtn, mhBtn, urBtn, stBtn, baBtn, ccBtn, lcBtn, apBtn, fbBtn;
    public bool monPnlActive;

    //Methods

    //Menu Opening via button pressing
    public void openMenu(GameObject menu)
    {
        if (menu.activeInHierarchy)
        {
            menu.SetActive(false);
        }
        else if (menu.activeInHierarchy == false)
        {
            menu.SetActive(true);
        }
    }

    //Open property panels
    public void openWhiteCopse()
    {
        propPanelCheck();
        openMenu(wcPnl);
    }

    public void openMillHouse()
    {
        propPanelCheck();
        openMenu(mhPnl);
    }

    public void openURQ()
    {
        propPanelCheck();
        openMenu(urPnl);
    }

    public void openSPM()
    {
        propPanelCheck();
        openMenu(stPnl);
    }

    public void openBA()
    {
        propPanelCheck();
        openMenu(baPnl);
    }

    public void openCC()
    {
        propPanelCheck();
        openMenu(ccPnl);
    }

    public void openLC()
    {
        propPanelCheck();
        openMenu(lcPnl);
    }

    public void openAP()
    {
        propPanelCheck();
        openMenu(apPnl);
    }

    public void openFB()
    {
        propPanelCheck();
        openMenu(fbPnl);
    }

    public void fbButton()
    {
        if (MoneyManager.totalgold >= 400)
        {
            applyPurchase(400, 15);
            baBtn.gameObject.SetActive(false);
        }
    }

    public void apButton()
    {
        if (MoneyManager.totalgold >= 600)
        {
            applyPurchase(600, 60);
            baBtn.gameObject.SetActive(false);
        }
    }

    public void lcButton()
    {
        if (MoneyManager.totalgold >= 2000)
        {
            applyPurchase(2000, 200);
            baBtn.gameObject.SetActive(false);
        }
    }

    public void baButton()
    {
        if (MoneyManager.totalgold >= 1000)
        {
            applyPurchase(1000, 50);
            baBtn.gameObject.SetActive(false);
        }
    }

    public void ccButton()
    {
        if (MoneyManager.totalgold >= 300)
        {
            applyPurchase(300, 15);
            ccBtn.gameObject.SetActive(false);
        }
    }

    public void wcButton()
    {
        if (MoneyManager.totalgold >= 500)
        {
            applyPurchase(500, 10);
            wcBtn.gameObject.SetActive(false);
        }
    }

    public void mhButton()
    {
        if (MoneyManager.totalgold >= 650)
        {
            applyPurchase(650, 20);
            mhBtn.gameObject.SetActive(false);
        }
    }

    public void urButton()
    {
        if (MoneyManager.totalgold >= 100)
        {
            applyPurchase(100, 10);
            urBtn.gameObject.SetActive(false);
        }
    }

    public void stButton()
    {
        if (MoneyManager.totalgold >= 300)
        {
            applyPurchase(300, 30);
            stBtn.gameObject.SetActive(false);
        }
    }
    public void propPanelCheck()
    {
        GameObject go = null;
        if (GameObject.FindWithTag("PropPanel") != null)
        {
            go = GameObject.FindWithTag("PropPanel");
        }
        if (go != null)
        {
            go.SetActive(false);
        }
    }
    public void chPanelCheck()
    {
        GameObject go = null;
        if (GameObject.FindWithTag("chPanel") != null)
        {
            go = GameObject.FindWithTag("chPanel");
        }
        if (go != null)
        {
            go.SetActive(false);
        }
    }
    //Misc
    void applyPurchase(float cost, float effect) 
    {
        MoneyManager.totalgold -= cost;
        MoneyManager.goldperminute += effect;
    }

}
//All code written by Jay Underwood (deShalom).
