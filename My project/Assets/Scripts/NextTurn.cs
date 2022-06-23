    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextTurn : MonoBehaviour
{
    public bool right;
    public bool left;
    public bool forward;
    public bool goBack;

    public static string direction;

    private List<string> list = new List<string>();

    void OnTriggerEnter(Collider other){
        if(right){
            list.Add("right");
        }
        if(left){
            list.Add("left");
        }
        if(forward){
            list.Add("forward");
        }
        if(goBack){
            list.Add("return");
        }  
        int index = Random.Range(0,list.Count);
        direction=list[index];
        list.Clear();
    }
}
