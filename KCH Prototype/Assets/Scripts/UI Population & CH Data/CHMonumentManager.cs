using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml.Serialization;
using System.IO;
using System.Xml;
using System.Text;

public class CHMonumentClass
{
    [XmlAttribute("BTName")]
    public string BTNname;

    [XmlElement("CHName")]
    public string CHMonName;
    [XmlElement("CHDescription")]
    public string CHMonDescription;
    [XmlElement("CHConstructionDat")]
    public string CHMonConDat;
    [XmlElement("CHFigures")]
    public string CHMonFigures;
    [XmlElement("CHPrice")]
    public string CHMonPrice;
    [XmlElement("CHGamepE")]
    public string CHMonEffect;
}

[XmlRoot("CHMonumentCollection")]
public class CHMonumentManager
{

    //Variables
    [XmlArray("CHMonuments")]
    [XmlArrayItem("CHMonument")]

    public List<CHMonumentClass> CHMonumentsList = new List<CHMonumentClass>();

    //Methods
    public static CHMonumentManager Load(string path)
    {
        TextAsset _xml = Resources.Load<TextAsset>(path);
        XmlSerializer serializer = new XmlSerializer(typeof(CHMonumentManager));
        StringReader reader = new StringReader(_xml.text);
        CHMonumentManager CHMonumentsList = serializer.Deserialize(reader) as CHMonumentManager;
        reader.Close();
        return CHMonumentsList;
    }
}
//All code written by Jay Underwood (deShalom).


