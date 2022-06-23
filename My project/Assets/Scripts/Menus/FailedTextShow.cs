using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FailedTextShow : MonoBehaviour
{
    public static string details;
    public Text text;

    void Start()
    {
        text.text=details;
    }
}
