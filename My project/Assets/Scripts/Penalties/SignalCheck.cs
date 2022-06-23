using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SignalCheck : MonoBehaviour
{
    public bool right;
    public bool left;

    void OnTriggerEnter(Collider other)
    {
        if(right){  //If the turn is on the right side
            if(!DirectionSignal.righties){  // verifies if the right signal was not on
                UpdatePenalties.penalties += 6;
                PenaltyIsFor.penalty="Did not signal correctly = 6";
            }
        }
        else if(left){
            if(!DirectionSignal.lefties){
                UpdatePenalties.penalties += 6;
                PenaltyIsFor.penalty="Did not signal correctly = 6";
            }
        }
    }
}
