using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyUI : MonoBehaviour
{
    //Variables
    public GameObject gOne, gTwo;

    //Methods
    private void Start()
    {
        gOne.SetActive(false);
        gTwo.SetActive(false);
    }
    void Update()
    {
        
    }

    public void Over() 
    {
        print("Testing");
        gOne.SetActive(true);
        gTwo.SetActive(true);
    }

    public void Out()
    {
        print("Testing two");
        gOne.SetActive(false);
        gTwo.SetActive(false);
    }
}
//All code written by Jay Underwood (deShalom).
