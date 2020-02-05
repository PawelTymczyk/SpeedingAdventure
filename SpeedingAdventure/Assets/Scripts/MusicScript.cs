using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicScript : MonoBehaviour
{
    public GameObject Music;
    
    void Start()
    {
        if(GameObject.FindGameObjectsWithTag("Music").Length >= 2 )
        {
            Destroy(Music);
        }

        DontDestroyOnLoad(Music);
    }

    void Update()
    { 
        Music.GetComponent<AudioSource>().volume = PlayerPrefs.GetFloat("Volume");
    }
}
