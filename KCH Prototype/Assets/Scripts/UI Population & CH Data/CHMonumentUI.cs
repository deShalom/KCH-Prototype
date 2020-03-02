using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Xml.Serialization;
using System.IO;
using System.Xml;
using System.Text;
public class CHMonumentUI : MonoBehaviour
{
    //Variables
    public const string path = "CHMonData";
    public CHMonumentManager i;

    //UI Variables
    public Text MonTitle, MonDescription;

    //Methods
    private void Awake()
    {
     CHMonumentManager i = CHMonumentManager.Load(path);
    }
    public void BAClicked()
    {
        foreach (CHMonumentClass CHMonument in i.CHMonumentsList)
        {
            if (CHMonument.MNname == "BA")
            {
                MonTitle.text = CHMonument.CHMonName;
                MonDescription.text = CHMonument.CHMonDescription;
            }
        }
    }
}
//All code written by Jay Underwood (deShalom).

