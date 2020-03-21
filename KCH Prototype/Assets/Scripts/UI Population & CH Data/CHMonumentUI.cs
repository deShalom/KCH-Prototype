using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Xml.Serialization;
using System.IO;
using System.Xml;
using System.Text;
using TMPro;
public class CHMonumentUI : MonoBehaviour
{
    //Variables
    public const string path = "CHMonData";
    public CHMonumentManager i;

    //UI Variables
    public TextMeshProUGUI MonTitle, MonDescription, MonDate, MonFounder;
    public GameObject iPanel;

    //Methods
    public void BAClicked()
    {
        iPanel.SetActive(true);
        CHMonumentManager i = CHMonumentManager.Load(path);
        foreach (CHMonumentClass CHMonument in i.CHMonumentsList)
        {
            if (CHMonument.MNname == "BA")
            {
                MonTitle.text = CHMonument.CHMonName;
                MonDescription.text = CHMonument.CHMonDescription;
                MonDate.text = CHMonument.CHMonConDat;
                MonFounder.text = CHMonument.CHMonFigures;
            }
        }
    }
    public void KCClicked()
    {
        iPanel.SetActive(true);
        CHMonumentManager i = CHMonumentManager.Load(path);
        foreach (CHMonumentClass CHMonument in i.CHMonumentsList)
        {
            if (CHMonument.MNname == "KC")
            {
                MonTitle.text = CHMonument.CHMonName;
                MonDescription.text = CHMonument.CHMonDescription;
                MonDate.text = CHMonument.CHMonConDat;
                MonFounder.text = CHMonument.CHMonFigures;
            }
        }
    }
    public void APClicked()
    {
        iPanel.SetActive(true);
        CHMonumentManager i = CHMonumentManager.Load(path);
        foreach (CHMonumentClass CHMonument in i.CHMonumentsList)
        {
            if (CHMonument.MNname == "AP")
            {
                MonTitle.text = CHMonument.CHMonName;
                MonDescription.text = CHMonument.CHMonDescription;
                MonDate.text = CHMonument.CHMonConDat;
                MonFounder.text = CHMonument.CHMonFigures;
            }
        }
    }
    public void LCClicked()
    {
        iPanel.SetActive(true);
        CHMonumentManager i = CHMonumentManager.Load(path);
        foreach (CHMonumentClass CHMonument in i.CHMonumentsList)
        {
            if (CHMonument.MNname == "LC")
            {
                MonTitle.text = CHMonument.CHMonName;
                MonDescription.text = CHMonument.CHMonDescription;
                MonDate.text = CHMonument.CHMonConDat;
                MonFounder.text = CHMonument.CHMonFigures;
            }
        }
    }

    public void FBClicked()
    {
        iPanel.SetActive(true);
        CHMonumentManager i = CHMonumentManager.Load(path);
        foreach (CHMonumentClass CHMonument in i.CHMonumentsList)
        {
            if (CHMonument.MNname == "FB")
            {
                MonTitle.text = CHMonument.CHMonName;
                MonDescription.text = CHMonument.CHMonDescription;
                MonDate.text = CHMonument.CHMonConDat;
                MonFounder.text = CHMonument.CHMonFigures;
            }
        }
    }

}
//All code written by Jay Underwood (deShalom).

