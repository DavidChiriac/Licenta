using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateTriggers : MonoBehaviour
{
    [SerializeField] private Collider collider1;
    [SerializeField] private Collider collider2;

    private float timer = 60.0f;
    
    void OnTriggerEnter(Collider other)
    {
        collider1.enabled = true;
        collider2.enabled = true;
    }

    private void FixedUpdate(){
        timer-=Time.deltaTime;
        if(timer<=0){
            collider1.enabled = false;
            collider2.enabled = false;
            timer=60;
        }
    }
}
