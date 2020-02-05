using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathTipTrigger : MonoBehaviour
{
    public GameObject CurrentTip;
    public GameObject NextTip;

    void OnTriggerEnter()
    {
        CurrentTip.SetActive(false);
        NextTip.SetActive(true);
    }
}
