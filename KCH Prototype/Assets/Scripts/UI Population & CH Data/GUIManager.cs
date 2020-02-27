using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GUIManager : MonoBehaviour
{
    //Variables
    public GameObject monPnl, conPnl, wcPnl, mhPnl, urPnl;
    public Button mon1Btn, tvBtn, wcBtn, mhBtn, urBtn;
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

    //Integrate to new format (Please)
    public void OpenmonPNL()
    {
        if (monPnlActive == false)
        {
            monPnl.SetActive(true);
            monPnlActive = true;
        }
        else if (monPnlActive == true)
        {
            monPnl.SetActive(false);
            monPnlActive = false;
        }
    }

    //Open Construction Panel
    public void OpenconPNL()
    {
        openMenu(conPnl);
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
    //Misc
    void applyPurchase(float cost, float effect) 
    {
        MoneyManager.totalgold -= cost;
        MoneyManager.goldperminute += effect;
    }



}
//All code written by Jay Underwood (deShalom).
