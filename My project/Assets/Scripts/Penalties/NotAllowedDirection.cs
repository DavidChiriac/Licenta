using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotAllowedDirection : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        UpdatePenalties.penalties += 6;
        PenaltyIsFor.penalty="Not allowed turn = 6";
    }
}
