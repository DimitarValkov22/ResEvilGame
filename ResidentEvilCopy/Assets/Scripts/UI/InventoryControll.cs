using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryControll : MonoBehaviour
{
    public GameObject theInventory;
    public GameObject FadeIn;
    public AudioSource MenuOpen;
    public bool isOpen = false;
    public AudioSource MenuClose;
    public bool canClose = false;


    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetButton("Cancel") && isOpen == false && canClose == false)
        {
            isOpen = true;
            MenuOpen.Play();
            FadeIn.SetActive(true);
            StartCoroutine(InvControll());
        }
        if(Input.GetButton("Cancel") && isOpen == true && canClose == true)
        {
            Time.timeScale = 1;
            Cursor.visible = false ;
            isOpen = false;
            MenuClose.Play();
            FadeIn.SetActive(true);
            StartCoroutine(InvControll());
        }
    }

    public void ExitButton()
    {
        Time.timeScale = 1;
        Cursor.visible = false;
        isOpen = false;
        MenuClose.Play();
        FadeIn.SetActive(true);
        StartCoroutine(InvControll());
    }

    IEnumerator InvControll()
    {
        yield return new WaitForSecondsRealtime(0.25f);
        if(isOpen == true)
        {
            theInventory.SetActive(true);
        }
        else
        {
            theInventory.SetActive(false);
        }
        yield return new WaitForSecondsRealtime(0.25f);
        FadeIn.SetActive(false);
        if (isOpen == true)
        {
            canClose = true;
            Time.timeScale = 0;
            Cursor.visible = true;
        }
        else
        {
            canClose = false;
        }
    }
}
