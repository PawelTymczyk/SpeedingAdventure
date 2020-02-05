using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChange : MonoBehaviour
{
    public GameObject NormalCamera;
    public GameObject FarCamera;
    public GameObject FPCamera;
    public GameObject BackCamera;
    public int CameraMode;

    void Update()
    {
        if(Input.GetButtonDown("ViewMode"))
        { 
            if(CameraMode == 3)
            {
                CameraMode = 0;
            }
            else
            {
                CameraMode++;
            }
            StartCoroutine(ModeChange());

        }
    }

    IEnumerator ModeChange()
    {
        yield return new WaitForSeconds(0.05f);
        if (CameraMode == 0)
        {
            NormalCamera.SetActive(true);
            BackCamera.SetActive(false);
        }
        if (CameraMode == 1)
        {
            FarCamera.SetActive(true);
            NormalCamera.SetActive(false);
        }
        if (CameraMode == 2)
        {
            FPCamera.SetActive(true);
            FarCamera.SetActive(false);
        }
        if (CameraMode == 3)
        {
            BackCamera.SetActive(true);
            FPCamera.SetActive(false);
        }
    }
}
