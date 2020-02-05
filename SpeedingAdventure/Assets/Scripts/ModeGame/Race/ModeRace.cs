using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ModeRace : MonoBehaviour
{
    public int ModeSelected;
    public GameObject RaceUI;
    public GameObject ScoreUI;
    public GameObject PlaceUI;
    public GameObject line;
    public GameObject AICar;

    void Start()
    {
        ModeSelected = ModeSelect.RaceType;

        if(ModeSelected == 2) // mode - race
        {
            AICar.SetActive(false);
            RaceUI.SetActive(false);
            ScoreUI.SetActive(false);
            PlaceUI.SetActive(true);
            line.SetActive(false);
        }
    }
}
