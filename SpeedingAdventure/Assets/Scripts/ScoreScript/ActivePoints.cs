using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivePoints : MonoBehaviour
{
    public int ModeSelected;
    public GameObject LapComple;
    public List<GameObject> Points = new List<GameObject>();

    void Start()
    {
        ModeSelected = ModeSelect.RaceType;

        if (ModeSelected == 0) // mode - score
        {
            PointStart();
        }
    }
    
    public void PointStart()
    {
        foreach (GameObject point in Points)
        {
            point.SetActive(true);
        }
    }
}
