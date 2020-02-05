using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathTrigger : MonoBehaviour
{
    public GameObject CurrentPathTriger;
    public GameObject NextPathTrigger;

    void OnTriggerEnter()
    {
        CurrentPathTriger.SetActive(false);
        NextPathTrigger.SetActive(true);

    }
}
