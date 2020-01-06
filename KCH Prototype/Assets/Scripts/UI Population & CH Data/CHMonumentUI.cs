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

    //UI Variables
    public Text MonTitle, MonDescription, MonPrice, MonEffects;

    //Methods
    public void Start()
    {
      
    }

    public void StoneHengeClicked()
    {
        CHMonumentManager i = CHMonumentManager.Load(path);

        foreach (CHMonumentClass CHMonument in i.CHMonumentsList)
        {
            if (CHMonument.BTNname == "CH Monument SH")
            {
                MonTitle.text = CHMonument.CHMonName;
                MonDescription.text = CHMonument.CHMonDescription;
                MonPrice.text = CHMonument.CHMonPrice;
                MonEffects.text = CHMonument.CHMonEffect;
            }
        }
    }
}
//All code written by Jay Underwood (deShalom).

