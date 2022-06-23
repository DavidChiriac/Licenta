using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarSpeed : MonoBehaviour
{
    public Text text;
    private double Speed;
    private Vector3 startingPosition, speedvec;

    private bool HighSpeedTriggered;    //We use this to avoid the case when the user brakes from 51 to 50 and immediately back to 51 so he will not be punished 2 times
    private float allowance;    //counter for not punish same high speed multiple times

    void Start() 
    {        
        startingPosition = transform.position;

        allowance = 10;
        HighSpeedTriggered = true; //I will start it on true because the car will be repositioned on a random spot and it will travel with a very high speed
                                    // so I need to not detect that movement
    }

    void FixedUpdate()
    {
        speedvec = ((transform.position - startingPosition) / Time.deltaTime);
        Speed = (int)(speedvec.magnitude) * 3.6;

        startingPosition = transform.position;
        text.text = Speed + "km/h";
        if(Speed>50){
            if(!HighSpeedTriggered){
                PenaltyIsFor.penalty="You passed the speed limit!";
                UpdatePenalties.penalties+=5;
                HighSpeedTriggered = true;
            }
        }
        if(HighSpeedTriggered && allowance > 0){
            allowance -= Time.deltaTime;
        }
        else{
            HighSpeedTriggered = false;
            allowance = 10;
        }
    }
}
