using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ModeTime : MonoBehaviour
{
    public int ModeSelected;
    public GameObject AICar;

    public static bool isTimeMode = false;

    void Start()
    {
        ModeSelected = ModeSelect.RaceType;

        if (ModeSelected == 1) // mode - time
        {
            isTimeMode = true;

            AICar.SetActive(false); 
        }
    }
}
