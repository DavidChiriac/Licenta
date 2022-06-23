using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RedLight : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        UpdatePenalties.penalties += 21;
        FailedTextShow.details="(You ran on a red light)";
        SceneManager.LoadScene(5);
    }
}
