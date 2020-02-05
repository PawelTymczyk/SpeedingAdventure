using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueScore : MonoBehaviour
{
    void OnTriggerEnter()
    {
        ModeScore.CurrentScore += 100;
        gameObject.SetActive(false);
    }
}
