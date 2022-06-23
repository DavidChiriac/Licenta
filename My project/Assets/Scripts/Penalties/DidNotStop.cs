using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DidNotStop : MonoBehaviour
{
    [SerializeField] private GameObject car;
    [SerializeField] private Collider collider1;
    
    void FixedUpdate(){
        Vector3 carVeloc = car.GetComponent<Rigidbody>().velocity;
        if(Mathf.Round(carVeloc.x)==0 && Mathf.Round(carVeloc.y)==0 && Mathf.Round(carVeloc.z)==0)
        {
            collider1.enabled = false;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        UpdatePenalties.penalties += 9;
        PenaltyIsFor.penalty = "You did not stop at a STOP sign = 9";
    }
}
