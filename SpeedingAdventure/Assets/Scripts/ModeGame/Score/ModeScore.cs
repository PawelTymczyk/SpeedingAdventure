using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ModeScore : MonoBehaviour
{
    public int ModeSelected;
    public GameObject RaceUI;
    public GameObject ScoreUI;
    public GameObject AICar;

    public static int CurrentScore;
    public int InternalScore;

    public GameObject ScoreValue;
    public GameObject ScoreObject;

    void Start()
    {
        ModeSelected = ModeSelect.RaceType;

        if(ModeSelected == 0) // mode - score
        {
            RaceUI.SetActive(false);
            ScoreUI.SetActive(true);
            AICar.SetActive(false); 
            ScoreObject.SetActive(true);
        }
    }

    void Update()
    {
        InternalScore = CurrentScore;
        ScoreValue.GetComponent<Text>().text = "" + InternalScore;
    }
}
