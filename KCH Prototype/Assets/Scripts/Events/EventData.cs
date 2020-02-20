using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml.Serialization;
using System.IO;
using System.Xml;
using System.Text;

public class EventClass
{
    [XmlAttribute("eName")]
    public string eName;

    [XmlElement("eLetter")]
    public string eLetter;
    [XmlElement("eLetterTwo")]
    public string eLetterTwo;
    [XmlElement("eLetterThree")]
    public string eLetterThree;
}

[XmlRoot("EventsCollection")]
public class EventData
{

    //Variables
    [XmlArray("Events")]
    [XmlArrayItem("Event")]

    public List<EventClass> EventsList = new List<EventClass>();

    //Methods
    public static EventData Load(string path)
    {
        TextAsset _xml = Resources.Load<TextAsset>(path);
        XmlSerializer serializer = new XmlSerializer(typeof(EventData));
        StringReader reader = new StringReader(_xml.text);
        EventData EventsList = serializer.Deserialize(reader) as EventData;
        reader.Close();
        return EventsList;
    }
}
//All code written by Jay Underwood (deShalom).
