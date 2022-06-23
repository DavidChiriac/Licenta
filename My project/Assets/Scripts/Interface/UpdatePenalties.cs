using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UpdatePenalties : MonoBehaviour
{
    [SerializeField] private Text penaltiesString;
    public static int penalties;
    public static int dificultyPoints;
    public static int necessaryDifficultyPoints;
    private float countdown;
    void Start()
    {
        penalties = 0;
        penaltiesString.text = "Penalties: " + penalties.ToString();
        countdown = 5;
        NextTurn.direction = "";
        dificultyPoints = 0;
        necessaryDifficultyPoints = 30;
    }

    void Update()
    {
        penaltiesString.text = "Penalties: " + penalties.ToString();
        if(UpdatePenalties.dificultyPoints >= necessaryDifficultyPoints){
            countdown -= Time.deltaTime;
            if(countdown<=0)
                if(UpdatePenalties.penalties<21){
                    SceneManager.LoadScene(4);
                }
                else{
                    SceneManager.LoadScene(5);
                }
        }
    }
}
