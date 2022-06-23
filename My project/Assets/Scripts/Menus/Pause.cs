using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public static bool isPaused = false;
    public GameObject canvas;
    private float countdown;
    
    void Start(){
        canvas.SetActive(false);
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)){
            isPaused = !isPaused;
            canvas.SetActive(isPaused);
            if(isPaused==true){
                Time.timeScale = 0;
            }
            else{
                Time.timeScale = 1;
            }
        }
    }
}