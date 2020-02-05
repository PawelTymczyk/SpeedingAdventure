using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartRace : MonoBehaviour
{
    public GameObject CountDown;

    public GameObject LapTimerMenager;

    public GameObject MyCar;
    public GameObject AICar;

    void Update()
    {
        if(CountDown.GetComponent<Text>().text == "0")
        {
            MyCar.GetComponent<RearWheelDrive>().enabled = true;
            if(ModeSelect.RaceType == 2)
            {
                AICar.SetActive(true);
            }

            if (ModeSelect.RaceType == 1)
            {
                LapTimerMenager.GetComponent<LapTimeMenager>().enabled = true;
            }
        }
    }
}
