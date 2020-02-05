using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapTimeMenager : MonoBehaviour
{
    public static int MinuteCount;
    public static int SecondCount;
    public static float MilisecondCount;
    public static string MiliSecondDisplay;

    public GameObject MinuteBox;
    public GameObject SecondBox;
    public GameObject MilisecondBox;

    public static float BestTime;

    void Update()
    {
        MilisecondCount += Time.deltaTime * 10;
        BestTime += Time.deltaTime;
        MiliSecondDisplay = MilisecondCount.ToString("F0");
        MilisecondBox.GetComponent<Text>().text = "" + MiliSecondDisplay;

        if (MilisecondCount >= 10)
        {
            MilisecondCount = 0;
            SecondCount += 1;
        }

        if (SecondCount <= 9)
        {
            SecondBox.GetComponent<Text>().text = "0" + SecondCount + ".";
        }
        else
        {
            SecondBox.GetComponent<Text>().text = "" + SecondCount + ".";
        }


        if (SecondCount >= 60)
        {
            SecondCount = 0;
            MinuteCount += 1; 
        }

        if (MinuteCount <= 9)
        {
            MinuteBox.GetComponent<Text>().text = "0" + MinuteCount + ":";
        }
        else
        {
            MinuteBox.GetComponent<Text>().text = "" + MinuteCount + ":";
        }
    }
}
