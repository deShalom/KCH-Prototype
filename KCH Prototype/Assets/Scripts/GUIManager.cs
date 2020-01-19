using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GUIManager : MonoBehaviour
{
    //Variables
    public GameObject monPnl, conPnl;
    public Button mon1Btn, tvBtn;
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

}
//All code written by Jay Underwood (deShalom).
