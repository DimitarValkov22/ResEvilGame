using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChange : MonoBehaviour
{
    public GameObject theCamera01;
    public GameObject theCamera02;
    public bool camOn = false;
    public int cameraNumber;
    
    void Start()
    {
        cameraNumber = 1;
        StartCoroutine(CameraSwitch());
    }

    IEnumerator CameraSwitch()
    {
        yield return new WaitForSecondsRealtime(5);
        theCamera02.SetActive(true);
        theCamera01.SetActive(false);
        camOn = true;
        cameraNumber = 2;
    }

}
