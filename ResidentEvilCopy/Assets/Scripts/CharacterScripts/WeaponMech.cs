using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponMech : MonoBehaviour
{
    public static bool isAiming = false;
    public Animator thePlayer;
    public float horizontalMove;

     void Start()
    {
        thePlayer.GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            isAiming = true;
            thePlayer.Play("Aiming1Pistol");
        }
        if (Input.GetMouseButtonUp(1))
        {
            isAiming = false;
        }

        if(isAiming == true)
        {
            if (Input.GetButton("Horizontal"))
            {
                horizontalMove = Input.GetAxis("Horizontal") * Time.deltaTime * 150;
                thePlayer.transform.Rotate(0, horizontalMove, 0);
            }
        }
    }
}
