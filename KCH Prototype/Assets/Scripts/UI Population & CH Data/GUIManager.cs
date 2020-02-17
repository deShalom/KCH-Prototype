using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GUIManager : MonoBehaviour
{
    //Variables
    public GameObject monPnl, conPnl, wcPnl, mhPnl;
    public Button mon1Btn, tvBtn, wcBtn, mhBtn;
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

    public void openWhiteCopse()
    {
        openMenu(wcPnl);
    }

    public void openMillHouse()
    {
        openMenu(mhPnl);
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

    void applyPurchase(float cost, float effect) 
    {
        MoneyManager.totalgold -= cost;
        MoneyManager.goldperminute += effect;
    }

}
//All code written by Jay Underwood (deShalom).
