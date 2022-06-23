using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resume : MonoBehaviour
{
    public GameObject canvas;
    public void ResumeGame(){
        canvas.SetActive(false);
        Time.timeScale = 1;
        Pause.isPaused = false;
    }
}
