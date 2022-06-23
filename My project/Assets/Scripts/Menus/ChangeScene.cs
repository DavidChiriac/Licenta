using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public int SceneNr;
    public void Change()
    {
        SceneManager.LoadScene(SceneNr);
    }

    public void StartGame()
    {
        Time.timeScale = 1;
        Pause.isPaused = false;
        SceneManager.LoadScene(2);
    }
}
