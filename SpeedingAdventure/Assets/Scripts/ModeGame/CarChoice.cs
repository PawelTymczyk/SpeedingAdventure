using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarChoice : MonoBehaviour
{
    // Red - 1; Yellow - 2; White - 3; Blue - 4;
    public GameObject RedBody;
    public GameObject YellowBody;
    public GameObject WhiteBody;
    public GameObject BlueBody;
    public int CarChosen;

    void Start()
    {
        CarChosen = GlobalCar.CarType;
        if(CarChosen == 1)
        {
            RedBody.SetActive(true);
        }

        if (CarChosen == 2)
        {
            YellowBody.SetActive(true);
        }

        if (CarChosen == 3)
        {
            WhiteBody.SetActive(true);
        }

        if (CarChosen == 4)
        {
            BlueBody.SetActive(true);
        }
    }
}
