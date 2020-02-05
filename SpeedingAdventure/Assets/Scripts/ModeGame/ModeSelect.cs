using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModeSelect : MonoBehaviour
{
    // 0 - score; 1 - Time; 2 - race
    public static int RaceType;
    public GameObject Track;

    public void ScoreMode()
    {
        RaceType = 0;
        Track.SetActive(true);
    }

    public void TimeMode()
    {
        RaceType = 1;
        Track.SetActive(true);
    }

    public void RaceMode()
    {
        RaceType = 2;
        Track.SetActive(true);
    }
}
