using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankControl : MonoBehaviour
{
    public GameObject thePlayer;
    public bool isMoving;
    public float horizontalMove;
    public float verticalMove;
    public bool isRunning;
    public bool backwardsCheck = false;
    
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            isRunning = true;
        }
        else
        {
            isRunning = false;
        }

        if(Input.GetButton("Horizontal") || Input.GetButton("Vertical"))
        {
            isMoving = true;
            if (Input.GetButton("Backwards"))
            {
                backwardsCheck = true;
                thePlayer.GetComponent<Animator>().Play("Backwards");
            }
            else
            {
                backwardsCheck = false;

                if(isRunning == false)
                {
                   thePlayer.GetComponent<Animator>().Play("Walk");
                }
                else
                {
                    thePlayer.GetComponent<Animator>().Play("Run");
                }
                
            }
            if(isRunning == false)
            {
                verticalMove = Input.GetAxis("Vertical") * Time.deltaTime * 4;
            }

            if(isRunning == true && backwardsCheck == false)
            {
                verticalMove = Input.GetAxis("Vertical") * Time.deltaTime * 13;
            }

            horizontalMove = Input.GetAxis("Horizontal") * Time.deltaTime * 150;
            thePlayer.transform.Rotate(0, horizontalMove, 0);
            thePlayer.transform.Translate(0, 0, verticalMove);
        }
        else
        {
            isMoving = false;
            thePlayer.GetComponent<Animator>().Play("Idle");
        }
    }
}
