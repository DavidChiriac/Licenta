using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeactivateTriggers : MonoBehaviour
{
    [SerializeField] private Collider collider1;
    [SerializeField] private Collider collider2;

    void OnTriggerEnter(Collider other)
    {
        collider1.enabled = false;
        collider2.enabled = false;
    }
}
