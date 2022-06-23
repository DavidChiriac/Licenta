using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HelloUser : MonoBehaviour
{
    public Text text;
    void Start()
    {
        text.text="Hello, "+GetUsername.username+"!";
    }
}
