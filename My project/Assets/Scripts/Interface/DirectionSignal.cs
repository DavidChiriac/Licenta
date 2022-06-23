using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DirectionSignal : MonoBehaviour
{
    [SerializeField] private GameObject left;
    [SerializeField] private GameObject right;

    public static bool lefties;
    public static bool righties;

    private float blinkTime;

    void Start(){                       //In the beginning both direction lights are off
        left.SetActive(false);
        right.SetActive(false);
        lefties = false;
        righties = false;
    }

    void FixedUpdate()
    {
        LeftSide();
        RightSide();
    }

    void LeftSide(){
        if(Input.GetKeyDown(KeyCode.Q)){            //when 'Q' is pressed the left direction light is turned on
            right.SetActive(false);                 //deactivate the right light
            righties = false;       

            lefties = true;                         

            blinkTime = 1;                          //counter for alternating the lights to on and off to create a real effect
        }
        if(lefties)
        {
            if(blinkTime>0.5){                      //half a second the light is on
                left.SetActive(true);
            }
            else if(blinkTime>0){                   //half a second the light is off
                left.SetActive(false);
            }
            else{                                   //reset the counter
                blinkTime = 1;
            }

            blinkTime -= Time.deltaTime;            //counts time in blinkTime

            if(Input.GetKeyDown(KeyCode.T)){        //when 'T' is pressed the direction light stops
                lefties = false;
                left.SetActive(false);
            }
        }
    }

    void RightSide(){
        if(Input.GetKeyDown(KeyCode.E)){
            left.SetActive(false);
            lefties = false;

            righties = true;

            blinkTime = 1;
        }

        if(righties)
        {
            if(blinkTime>0.5){                      //half a second the light is on
                right.SetActive(true);
            }
            else if(blinkTime>0){                   //half a second the light is off
                right.SetActive(false);
            }
            else{                                   //reset the counter
                blinkTime = 1;
            }

            blinkTime -= Time.deltaTime;            //counts time in blinkTime

            if(Input.GetKeyDown(KeyCode.T)){        //when 'T' is pressed the direction light stops
                righties = false;
                right.SetActive(false);
            }
        }
            
    }
}
