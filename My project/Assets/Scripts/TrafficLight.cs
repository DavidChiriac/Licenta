using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrafficLight : MonoBehaviour
{
    [SerializeField] private Material green1;
    [SerializeField] private Material yellow;
    [SerializeField] private Material red1;
    [SerializeField] private Material green2;
    [SerializeField] private Material red2;

    [SerializeField] private float time;

    [SerializeField] private Collider colider1;
    [SerializeField] private Collider colider2;

    private float timeRemaining;
    // Start is called before the first frame update
    void Start()
    {
        green1.color=Color.black;
        yellow.color=Color.black;
        red1.color=Color.black;
        green2.color=Color.black;
        red2.color=Color.black;
        timeRemaining = 2*time;
    }

    // Update is called once per frame
    void Update()
    {
        timeRemaining-=Time.deltaTime;
        if(timeRemaining>time+5){
            colider1.enabled = false;
            colider2.enabled = true;
            green1.color=Color.green;
            yellow.color=Color.black;
            red1.color=Color.black;
            green2.color=Color.black;
            red2.color=Color.red;
        }
        else if(timeRemaining>time){
            yellow.color=Color.yellow;
        }
        else if(timeRemaining>5){
            colider1.enabled = true;
            colider2.enabled = false;
            green1.color=Color.black;
            yellow.color=Color.black;
            red1.color=Color.red;
            green2.color=Color.green;
            red2.color=Color.black;
        }
        else if(timeRemaining>=0 && timeRemaining <= 5){
            yellow.color=Color.yellow;
        }
        else {
            timeRemaining=2*time;
        }

    }
}
