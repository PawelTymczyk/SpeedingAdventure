using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SettingsMenu : MonoBehaviour
{
    public Dropdown resolutionsDropDown;
    public static float VOLUME;

    public GameObject PathTipCheckbox;

    //public GameObject PathTipText;
    private int PathTip;

    Resolution[] resolutions;
    void Start()
    {
        resolutions = Screen.resolutions;

        resolutionsDropDown.ClearOptions();

        List<string> options = new List<string>();
        
        int currentResolutionIndex = 0;
        for(int i = 0; i < resolutions.Length; i++)
        {
            string option = resolutions[i].width + " x " + resolutions[i].height;
            options.Add(option);

            if (resolutions[i].width == Screen.currentResolution.width && 
               resolutions[i].height == Screen.currentResolution.height)
            {
                currentResolutionIndex = i;
            }
        }

        resolutionsDropDown.AddOptions(options);
        resolutionsDropDown.value = currentResolutionIndex;
        resolutionsDropDown.RefreshShownValue();



        PathTip = PlayerPrefs.GetInt("PathTip");
        //if(PathTip == 1)
        //{
        //    PathTipCheckbox.GetComponent<Toggle>().isOn = true;
        //}
        //else
        //{
        //    PathTipCheckbox.GetComponent<Toggle>().isOn = false;
        //}
    }

    public void SetVolume (float volume)
    {
        print(volume);
        PlayerPrefs.SetFloat("Volume", volume);
    }

    public void SetQuality (int qualityIndex)
    { 
        QualitySettings.SetQualityLevel(qualityIndex);
    }

    public void SetFullScreen(bool isFullScreen)
    {
        Screen.fullScreen = isFullScreen;
    }

    public void SetResolution (int resolutionIndex)
    {
        Resolution resolution = resolutions[resolutionIndex];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }

    public void ResetPlayerPrefs()
    {
        print("Reset czasu");
        PlayerPrefs.GetFloat("RawTime");
    }

    public void TipPath()
    {
        if (PathTip == 1)
        {
            PlayerPrefs.SetInt("PathTip", 0);
            print("set na nieprawda");
        }
        else
        {
            PlayerPrefs.SetInt("PathTip", 1);
            print("prawda");
        }
        SceneManager.LoadScene(5);
    }

    //private void SetPathTipText()
    //{
    //    if (true)
    //    {

    //    }
    //    else
    //    {

    //    }
    //}
}
