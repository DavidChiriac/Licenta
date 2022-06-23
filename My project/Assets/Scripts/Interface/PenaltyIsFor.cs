using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PenaltyIsFor : MonoBehaviour
{
    public static string penalty;
    private float counter=3.0f;
    public Text text;
    void Update()
    {
        if(!string.Equals(penalty,"")){
            text.text=penalty;
            counter-=Time.deltaTime;
            Debug.Log(penalty);
            Debug.Log(counter);
        }
        if(counter<=0){
            penalty="";
            text.text="";
            counter=3.0f;
        }
    }
}
