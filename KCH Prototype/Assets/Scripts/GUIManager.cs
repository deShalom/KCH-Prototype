using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GUIManager : MonoBehaviour
{
    //Variables
    public GameObject monPnl;
    public Button mon1Btn, tvBtn;
    public bool monPnlActive;

    //Composition
    private JsCommonCode cc;

    //Methods
    void Start()
    {

    }

    void Update()
    {

    }

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

}
//All code written by Jay Underwood (deShalom).
