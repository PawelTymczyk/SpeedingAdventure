using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadLapTime : MonoBehaviour
{
    public int MinuteCount;
    public int SecondCount;
    public float MiliescondCount;
    public GameObject MinuteDisplay;
    public GameObject SecondDisplay;
    public GameObject MilisecondDisplay;

    public int NumberMap;

    void Update()
    { 
        MinuteCount = PlayerPrefs.GetInt("MinuteSave");
        SecondCount = PlayerPrefs.GetInt("SecondSave");
        MiliescondCount = PlayerPrefs.GetFloat("MilisecondSave");

        MinuteDisplay.GetComponent<Text>().text = "" + MinuteCount + ":";
        SecondDisplay.GetComponent<Text>().text = "" + SecondCount + ".";
        MilisecondDisplay.GetComponent<Text>().text = "" + MiliescondCount; 

    }
}
