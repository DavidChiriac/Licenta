using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CancelDirection : MonoBehaviour
{
    public bool right;
    public bool left;
    public bool forward;
    public bool back;

    public int intersectionPoints;

    void OnTriggerEnter(Collider other){
        if(right == true){
            if(string.Equals(NextTurn.direction,"right")){
                UpdatePenalties.dificultyPoints += intersectionPoints;
            }
            else{
                UpdatePenalties.penalties += 3;
                PenaltyIsFor.penalty="Did not follow the instructions = 3";
            }
        }
        if(left == true){
            if(string.Equals(NextTurn.direction,"left")){
                UpdatePenalties.dificultyPoints += intersectionPoints;
            }
            else{
                UpdatePenalties.penalties += 3;
                PenaltyIsFor.penalty="Did not follow the instructions = 3";
            }
        }
        if(forward == true){
            if(string.Equals(NextTurn.direction,"forward")){
                UpdatePenalties.dificultyPoints += intersectionPoints;
            }
            else{
                UpdatePenalties.penalties += 3;
                PenaltyIsFor.penalty="Did not follow the instructions = 3";
            }
        }
        if(back == true){
            if(string.Equals(NextTurn.direction,"return")){
                UpdatePenalties.dificultyPoints += intersectionPoints;
            }
            else{
                UpdatePenalties.penalties += 3;
                PenaltyIsFor.penalty="Did not follow the instructions = 3";
            }
        }
        NextTurn.direction = "";
    }
}
