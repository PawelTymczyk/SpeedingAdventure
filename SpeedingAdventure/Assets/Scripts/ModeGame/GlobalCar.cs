using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalCar : MonoBehaviour
{
    // Cars: Red - 1 ;  Yellow - 2 ;    White - 3 ;     Blue - 4 
    public static int CarType;
    public GameObject Mode;

    public void RedCar()
    {
        CarType = 1;
        Mode.SetActive(true);
    }

    public void YellowCar ()
    {
        CarType = 2;
        Mode.SetActive(true);
    }

    public void WhiteCar()
    {
        CarType = 3;
        Mode.SetActive(true);
    }

    public void BlueCar()
    {
        CarType = 4;
        Mode.SetActive(true);
    }
}
