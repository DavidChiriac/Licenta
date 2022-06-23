using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Direction : MonoBehaviour
{
    public GameObject right;
    public GameObject left;
    public GameObject forward;
    public GameObject goBack;
    public GameObject NextDirectionText;

    private bool ok = false;

    void Start()
    {
        right.SetActive(false);
        left.SetActive(false);
        forward.SetActive(false);
        goBack.SetActive(false);
        NextDirectionText.SetActive(false);
    }

    void Update()
    {
        ok = false;
        if(string.Equals(NextTurn.direction,"right")){
            right.SetActive(true);
            ok=true;
        }
        else{
            right.SetActive(false);
        }
        if(string.Equals(NextTurn.direction,"left")){
            left.SetActive(true);
            ok=true;
        }
        else{
            left.SetActive(false);
        }
        if(string.Equals(NextTurn.direction,"forward")){
            forward.SetActive(true);
            ok=true;
        }
        else{
            forward.SetActive(false);
        }
        if(string.Equals(NextTurn.direction,"return")){
            ok=true;
            goBack.SetActive(true);
        }
        else{
            goBack.SetActive(false);
        }
        if(ok){
            NextDirectionText.SetActive(true);
        }
        else{
            NextDirectionText.SetActive(false);
        }
    }
}
