using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    //Variables
    int switchVar = 0;
    int switchTimer = 0;

    //Methods
    private void Update()
    {
        yearChecker();
    }

    void yearChecker()
    {
        if (MoneyManager.cYear == 1066 && switchTimer == 0)
        {
            switchVar = 1;
            eventHolder();
            switchTimer = 1;
        }
    }

    void eventHolder() 
    {
        //Switch
        switch (switchVar)
        {
            case 1:
                penedenHeathEvent();
                break;
            case 2:
                print("Working two");
                break;
        }

    }

    void penedenHeathEvent() 
    {
        print("Working");
    }

}
//All code written by Jay Underwood (deShalom)