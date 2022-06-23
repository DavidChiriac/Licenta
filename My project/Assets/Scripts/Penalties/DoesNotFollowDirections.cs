using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoesNotFollowDirections : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        UpdatePenalties.penalties += 6;
        PenaltyIsFor.penalty="Wrong direction = 6";
    }
}
