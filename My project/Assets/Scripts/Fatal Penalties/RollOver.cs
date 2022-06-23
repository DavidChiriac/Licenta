using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RollOver : MonoBehaviour
{
    public GameObject car;
    void Update()
    {
        if((Mathf.Abs(car.transform.rotation.eulerAngles.z) > 80 && Mathf.Abs(car.transform.rotation.eulerAngles.z) < 280) ||
                Mathf.Abs(car.transform.rotation.eulerAngles.x) > 80 && Mathf.Abs(car.transform.rotation.eulerAngles.x) < 280){
            UpdatePenalties.penalties += 21;
            FailedTextShow.details = "(You rolled over)";
            SceneManager.LoadScene(5);
        }
    }
}
