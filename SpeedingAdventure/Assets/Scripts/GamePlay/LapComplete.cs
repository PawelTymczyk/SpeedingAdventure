using UnityEngine;
using UnityEngine.UI;
//using System.IO;

public class LapComplete : MonoBehaviour
{
    public GameObject LapCompleteTrigger;
    public GameObject FirstTrigger;

    public GameObject MinuteDisplay;
    public GameObject SecondDisplay;
    public GameObject MilisecondDisplay;

    public GameObject LapCounter;
    public int LapsDone;

    public float bestTime;

    public GameObject RaceFinish;

    public int NumberMap;

    void OnTriggerEnter()
    {
        LapsDone += 1;

        bestTime = PlayerPrefs.GetFloat("RawTime");

        if (bestTime >= LapTimeMenager.BestTime || bestTime * 1 == 0)
        {
            if (LapTimeMenager.SecondCount <= 9)
            {
                SecondDisplay.GetComponent<Text>().text = "0" + LapTimeMenager.SecondCount + ".";
            }
            else
            {
                SecondDisplay.GetComponent<Text>().text = "" + LapTimeMenager.SecondCount + ".";
            }


            if (LapTimeMenager.MinuteCount <= 9)
            {
                MinuteDisplay.GetComponent<Text>().text = "0" + LapTimeMenager.MinuteCount + ".";
            }
            else
            {
                MinuteDisplay.GetComponent<Text>().text = "" + LapTimeMenager.MinuteCount + ".";
            }

            MilisecondDisplay.GetComponent<Text>().text = "" + LapTimeMenager.MilisecondCount;

            PlayerPrefs.SetInt("MinuteSave", LapTimeMenager.MinuteCount);
            PlayerPrefs.SetInt("SecondSave", LapTimeMenager.SecondCount);
            PlayerPrefs.SetFloat("MilisecondSave", LapTimeMenager.MilisecondCount);
            PlayerPrefs.SetFloat("RawTime", LapTimeMenager.BestTime);

        }

        if (LapsDone == 2)
        {
            RaceFinish.SetActive(true);
        }

        LapTimeMenager.MinuteCount = 0;
        LapTimeMenager.SecondCount = 0;
        LapTimeMenager.MilisecondCount = 0;
        LapTimeMenager.BestTime = 0;

        LapCounter.GetComponent<Text>().text = "" + LapsDone;
        FirstTrigger.SetActive(true);
        LapCompleteTrigger.SetActive(false);

    }
}
