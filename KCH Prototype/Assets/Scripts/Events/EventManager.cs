﻿using System.Collections;
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
    public Text uiTitle, uiText, btnOneText, btnTwoText, btnThreeText;
    public GameObject eventPop, btnOne, btnTwo, btnThree, info;
    public Button btn, btn2, btn3, btni;

    //Methods

    void Start()
    {
        i = EventData.Load(path);
        btn = btnOne.GetComponent<Button>();
        btn2 = btnTwo.GetComponent<Button>();
        btn3 = btnThree.GetComponent<Button>();
        btni = info.GetComponent<Button>();
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
        if (MoneyManager.cYear == 1381 && switchTimer == 1)
        {
            switchVar = 2;
            eventHolder();
            switchTimer = 2;
        }
        if (MoneyManager.cYear == 1557 && switchTimer == 2)
        {
            switchVar = 3;
            eventHolder();
            switchTimer = 3;
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
                peasantsRevoltEvent();
                break;
            case 3:
                BurningsEvent();
                break;
        }

    }
    //Peneden Heath event methods
    void penedenHeathEvent() 
    {
        eventPop.SetActive(true);
        btnOne.SetActive(true);
        btnOneText.text = "Attend!";
        uiTitle.text = i.EventsList[0].eName.ToString();
        uiText.text = i.EventsList[0].eLetter.ToString();
        btn.onClick.AddListener(penedenHeathAttend);
        btni.onClick.AddListener(penedenHeathInfo);
        
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
       btnOne.SetActive(false);
       btnTwo.SetActive(false);
        btnThree.SetActive(false);
    }

    public void penedenHeathInfo()
    {
        Application.OpenURL("de-shalom.co.uk");
        print("Info working");
    }
    //Peasants revolt methods
    void peasantsRevoltEvent()
    {
        eventPop.SetActive(true);
        btnTwo.SetActive(true);
        btnTwoText.text = "Worrying news. We must wait!";
        uiTitle.text = i.EventsList[1].eName.ToString();
        uiText.text = i.EventsList[1].eLetter.ToString();
        btn2.onClick.AddListener(peasantsRevoltAttack);
        btni.onClick.AddListener(penedenHeathInfo);

    }

    public void peasantsRevoltAttack()
    {
        uiText.text = i.EventsList[1].eLetterTwo.ToString();
        btnTwoText.text = "Damn the rebel scum!";
        btn2.onClick.AddListener(peasantsRevoltOver);
    }

    public void peasantsRevoltOver()
    {
        uiText.text = i.EventsList[1].eLetterThree.ToString();
        btnTwoText.text = "Return home!";
        btn2.onClick.AddListener(penedenHeathClose);
    }

    public void peasantsRevoltInfo()
    {
        Application.OpenURL("de-shalom.co.uk");
        print("Info working");
    }
    //Refermation burning methods
    void BurningsEvent()
    {
        eventPop.SetActive(true);
        btnThree.SetActive(true);
        btnThreeText.text = "Ill times.";
        uiTitle.text = i.EventsList[2].eName.ToString();
        uiText.text = i.EventsList[2].eLetter.ToString();
        btn3.onClick.AddListener(BurningsCrowds);
        btni.onClick.AddListener(BurningsInfo);
    }

    public void BurningsCrowds()
    {
        uiText.text = i.EventsList[2].eLetterTwo.ToString();
        btnThreeText.text = "How is this justice?";
        btn3.onClick.AddListener(BurningsOver);
    }

    public void BurningsOver()
    {
        uiText.text = i.EventsList[2].eLetterThree.ToString();
        btnThreeText.text = "Long may the martyrs be remembered.";
        btn3.onClick.AddListener(penedenHeathClose);
    }

    public void BurningsInfo()
    {
        Application.OpenURL("de-shalom.co.uk");
        print("Info working");
    }
}
//All code written by Jay Underwood (deShalom)