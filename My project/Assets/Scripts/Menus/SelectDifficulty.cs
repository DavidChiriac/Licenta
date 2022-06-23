using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectDifficulty : MonoBehaviour
{
    public void Easy(){
        UpdatePenalties.necessaryDifficultyPoints=30;
        SceneManager.LoadScene(3);
    }
    public void Medium(){
        UpdatePenalties.necessaryDifficultyPoints=45;
        SceneManager.LoadScene(3);
    }
    public void Hard(){
        UpdatePenalties.necessaryDifficultyPoints=60;
        SceneManager.LoadScene(3);
    }
}
