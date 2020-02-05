using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPathTip : MonoBehaviour
{
    public GameObject ObjectOfPathTips;
    void Start()
    {
        if(PlayerPrefs.GetInt("PathTip") == 0)
        {
            ObjectOfPathTips.SetActive(false);
        }
        
    }
}
