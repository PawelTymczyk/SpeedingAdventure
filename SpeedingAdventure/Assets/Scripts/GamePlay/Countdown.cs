﻿using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{
    public GameObject CountDown;
    public AudioSource GetReady;
    public AudioSource GoAudio;
    public AudioSource LevelMusic;

    private float volume;
    
    void Start()
    {
        StartCoroutine(CountStart());
    }

    void Update()
    {
        volume = PlayerPrefs.GetFloat("Volume");
        GetReady.volume = volume;
        GoAudio.volume = volume;
        LevelMusic.volume = volume;
    }

    IEnumerator CountStart()
    {
        yield return new WaitForSeconds(0.5f);
        CountDown.GetComponent<Text>().text = "3";

        GetReady.Play();

        CountDown.SetActive(true);
        yield return new WaitForSeconds(1);
        CountDown.SetActive(false);

        CountDown.GetComponent<Text>().text = "2";
        GetReady.Play();

        CountDown.SetActive(true);
        yield return new WaitForSeconds(1);
        CountDown.SetActive(false);

        CountDown.GetComponent<Text>().text = "1";
        GetReady.Play();

        CountDown.SetActive(true);
        yield return new WaitForSeconds(1);
        CountDown.SetActive(false);

        CountDown.GetComponent<Text>().text = "0";
        GoAudio.Play();
        yield return new WaitForSeconds(1);
        LevelMusic.Play();
    }
}