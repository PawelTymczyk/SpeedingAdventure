using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonOptions : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(2);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(1);
    }

    public void Track01()
    {
        SceneManager.LoadScene(3);
    }

    public void Credits()
    {
        SceneManager.LoadScene(4);
    }

    public void Options()
    {
        SceneManager.LoadScene(5);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void SceneControl()
    {
        SceneManager.LoadScene(6);
    }

    public void CityTrack()
    {
        SceneManager.LoadScene(7);
    }

    public void PrakTrack()
    {
        SceneManager.LoadScene(8);
    }

    public void AchivnetScene()
    {
        SceneManager.LoadScene(9);
    }

    //public void Track04()
    //{
        //SceneManager.LoadScene();
    //}
}
