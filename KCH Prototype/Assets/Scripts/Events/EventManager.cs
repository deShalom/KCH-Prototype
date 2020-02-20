using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EventManager : MonoBehaviour
{
    //Variables
    int switchVar = 0;
    int switchTimer = 0;
    public const string path = "Events";
    public EventData i;

    //UI Variables
    public Text uiTitle, uiText, btnOneText;
    public GameObject eventPop, btnOne;
    public Button btn;

    //Methods

    void Start()
    {
        i = EventData.Load(path);
        btn = btnOne.GetComponent<Button>();
    }
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
    //Peneden Heath event methods
    void penedenHeathEvent() 
    {
        eventPop.SetActive(true);
        btnOneText.text = "Attend!";
        uiTitle.text = i.EventsList[0].eName.ToString();
        uiText.text = i.EventsList[0].eLetter.ToString();
        btn.onClick.AddListener(penedenHeathAttend);
        
    }
    public void penedenHeathAttend()
    {
        uiText.text = i.EventsList[0].eLetterTwo.ToString();
        btnOneText.text = "Justice must be ensured!";
        btn.onClick.AddListener(penedenHeathJury);
    }

    public void penedenHeathJury()
    {
        uiText.text = i.EventsList[0].eLetterThree.ToString();
        btnOneText.text = "Return home!";
        btn.onClick.AddListener(penedenHeathClose);
    }

    public void penedenHeathClose()
    {
       eventPop.SetActive(false);
    }

}
//All code written by Jay Underwood (deShalom)