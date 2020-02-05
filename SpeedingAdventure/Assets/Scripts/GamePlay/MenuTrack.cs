using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuTrack : MonoBehaviour
{
    public GameObject MinuteBox;
    public GameObject SecondBox;
    public GameObject MilisecondBox;

    public GameObject menu;
    public int CurrentScene;
    private bool IsMenu = false;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(IsMenu == true)
            {
                menu.SetActive(false);
                Time.timeScale = 1;
            }
            else
            {
                menu.SetActive(true);
                Time.timeScale = 0;
            }
        }
    }

    public void MenuScene()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(1);
    }

    public void OptionScene()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(5);
    }
    public void ReloadCurrentScene()
    {
        Time.timeScale = 1;

        MinuteBox.GetComponent<Text>().text = "00:";
        SecondBox.GetComponent<Text>().text = "00.";
        MilisecondBox.GetComponent<Text>().text = "0";

        LapTimeMenager.MinuteCount = 0;
        LapTimeMenager.SecondCount = 0;
        LapTimeMenager.MilisecondCount = 0;

        ModeScore.CurrentScore = 0;
        SceneManager.LoadScene(CurrentScene);
    }

    public void ShowOff()
    {
        menu.SetActive(false);
        Time.timeScale = 1;
    }
}
