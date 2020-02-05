using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyMusic : MonoBehaviour
{
    void Start()
    {
        Destroy(GameObject.Find("Music"));
    }
}
