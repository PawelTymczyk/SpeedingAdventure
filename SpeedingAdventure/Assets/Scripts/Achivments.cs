using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Achivments : MonoBehaviour
{
    public GameObject forestTime;
    public GameObject forestScore;
    public GameObject forestRace;

    public GameObject cityTime;
    public GameObject cityScore;
    public GameObject cityRace;

    public GameObject torTime;
    public GameObject torScore;
    public GameObject torRace;


    private int forestTimeValue;
    private int forestScoreValue;
    private int forestRaceValue;

    private int cityTimeValue;
    private int cityScoreValue;
    private int cityRaceValue;

    private int torTimeValue;
    private int torScoreValue;
    private int torRaceValue;


    void Start()
    {
        GetValue();
        SetActiveInactive();
    }
    
    void Update()
    {
        GetValue();
        SetActiveInactive();
    }



    private void ResetAchivments()
    {
        SetFalseValue();
        SetActiveInactive();
    }

    private void GetValue()
    {
        forestTimeValue = PlayerPrefs.GetInt("forestTimeAchivment");
        forestScoreValue = PlayerPrefs.GetInt("forestScoreAchivment");
        forestRaceValue = PlayerPrefs.GetInt("forestRaceAchivment");

        cityTimeValue = PlayerPrefs.GetInt("cityTimeAchivment");
        cityScoreValue = PlayerPrefs.GetInt("cityScoreAchivment");
        cityRaceValue = PlayerPrefs.GetInt("cityRaceAchivment");

        torTimeValue = PlayerPrefs.GetInt("torTimeAchivment");
        torScoreValue = PlayerPrefs.GetInt("torScoreAchivment");
        torRaceValue = PlayerPrefs.GetInt("torRaceAchivment");
    }

    private void SetFalseValue()
    {
        PlayerPrefs.SetInt("forestTimeAchivment", 0);
        PlayerPrefs.SetInt("forestScoreAchivment", 0);
        PlayerPrefs.SetInt("forestRaceAchivment", 0);

        PlayerPrefs.SetInt("cityTimeAchivment", 0);
        PlayerPrefs.SetInt("cityScoreAchivment", 0);
        PlayerPrefs.SetInt("cityRaceAchivment", 0);

        PlayerPrefs.SetInt("torTimeAchivment", 0);
        PlayerPrefs.SetInt("torScoreAchivment", 0);
        PlayerPrefs.SetInt("torRaceAchivment", 0);
    }

    private void SetActiveInactive()
    {
        if (forestTimeValue == 1)
        {
            forestTime.SetActive(true);
        }
        else
        {
            forestTime.SetActive(false);
        }

        if (forestScoreValue == 1)
        {
            forestScore.SetActive(true);
        }
        else
        {
            forestScore.SetActive(false);
        }

        if (forestRaceValue == 1)
        {
            forestRace.SetActive(true);
        }
        else
        {
            forestRace.SetActive(false);
        }

        if (cityTimeValue == 1)
        {
            cityTime.SetActive(true);
        }
        else
        {
            cityTime.SetActive(false);
        }

        if (cityScoreValue == 1)
        {
            cityScore.SetActive(true);
        }
        else
        {
            cityScore.SetActive(false);
        }

        if (cityRaceValue == 1)
        {
            cityRace.SetActive(true);
        }
        else
        {
            cityRace.SetActive(false);
        }

        if (torTimeValue == 1)
        {
            torTime.SetActive(true);
        }
        else
        {
            torTime.SetActive(false);
        }

        if (torScoreValue == 1)
        {
            torScore.SetActive(true);
        }
        else
        {
            torScore.SetActive(false);
        }

        if (torRaceValue == 1)
        {
            torRace.SetActive(true);
        }
        else
        {
            torRace.SetActive(false);
        }
    }

    private void Reload()
    {
        SceneManager.LoadScene(9);
    }

    // Setter to button for checking saving achivments
    public void SetOne()
    {
        PlayerPrefs.SetInt("forestTimeAchivment", 1);
        PlayerPrefs.SetInt("forestScoreAchivment", 0);
        PlayerPrefs.SetInt("forestRaceAchivment", 1);

        PlayerPrefs.SetInt("cityTimeAchivment", 0);
        PlayerPrefs.SetInt("cityScoreAchivment", 1);
        PlayerPrefs.SetInt("cityRaceAchivment", 0);
    }
}
