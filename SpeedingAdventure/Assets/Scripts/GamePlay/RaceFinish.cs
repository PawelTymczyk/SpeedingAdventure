using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RaceFinish : MonoBehaviour
{
    public GameObject AICar;
    public GameObject LevelMusic;
    public GameObject CompleteTrigger;
    public AudioSource FinishMusic;
    public GameObject CoutingTime;

    public GameObject FinishScreen;

    public int NumerRace;
    public GameObject position;
    public GameObject TimeMedal;
    public GameObject ScoreMedal;
    public GameObject RaceMedal;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            FinishScreen.SetActive(false);
            SceneManager.LoadScene(1);
        }
    }

    void OnTriggerEnter()
    {
        CompleteTrigger.SetActive(false);
        LevelMusic.SetActive(false);
        FinishMusic.Play();
        FinishScreen.SetActive(true);

        if (ModeSelect.RaceType == 0) // Score Mode
        { 
            if(ModeScore.CurrentScore > 2000 && NumerRace == 0)
            {
                PlayerPrefs.SetInt("forestScoreAchivment", 1);
                ScoreMedal.SetActive(true);
            }
            else if(ModeScore.CurrentScore > 2000 && NumerRace == 1)
            {
                PlayerPrefs.SetInt("cityScoreAchivment", 1);
                ScoreMedal.SetActive(true);
            }
            else if (ModeScore.CurrentScore > 2000 && NumerRace == 2)
            {
                PlayerPrefs.SetInt("torScoreAchivment", 1);
                ScoreMedal.SetActive(true);
            }
        }

        if(ModeSelect.RaceType == 1) // Time Mode
        { 
            CoutingTime.SetActive(false);
            if (NumerRace == 0 ) // mniejszy niż minuta
            {
                PlayerPrefs.SetInt("forestTimeAchivment", 1);
                TimeMedal.SetActive(true);
            }
            else if (NumerRace == 1) // mniejszy niż 3.30
            {
                PlayerPrefs.SetInt("cityTimeAchivment", 1);
                TimeMedal.SetActive(true);
            }
            else if (NumerRace == 2) // ?? 
            {
                PlayerPrefs.SetInt("torTimeAchivment", 1);
                TimeMedal.SetActive(true);
            }

        }

        if(ModeSelect.RaceType == 2) // Race Mode
        {
            if (position.GetComponent<Text>().text == "1 miejsce")
            {
                if (NumerRace == 0)
                {
                    PlayerPrefs.SetInt("forestRaceAchivment", 1);
                    RaceMedal.SetActive(true);
                }
                else if (NumerRace == 1)
                {
                    PlayerPrefs.SetInt("cityRaceAchivment", 1);
                    RaceMedal.SetActive(true);
                }

                else if (NumerRace == 2)
                {
                    PlayerPrefs.SetInt("torRaceAchivment", 1);
                    RaceMedal.SetActive(true);
                }
            }
        }
    }
}
