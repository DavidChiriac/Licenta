using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Detectcrash : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if(!other.isTrigger){
            UpdatePenalties.penalties += 21;
            FailedTextShow.details="(You crashed)";
            Debug.Log(other.name);
            SceneManager.LoadScene(5);
        }
    }
}
