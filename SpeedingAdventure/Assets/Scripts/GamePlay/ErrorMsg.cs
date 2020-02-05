using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ErrorMsg : MonoBehaviour
{
    public GameObject ErrorText;

    public void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            StartCoroutine(ShowHideError());
        }
    }

    IEnumerator ShowHideError()
    {
        ErrorText.SetActive(true);
        yield return new WaitForSeconds(2f);
        ErrorText.SetActive(false);
    }
}
