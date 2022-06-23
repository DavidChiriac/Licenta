using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GetUsername : MonoBehaviour
{
    public Button myButton; 
    public InputField inptField;
    public static string username;
    public void EnableButton()
    {   
        username = inptField.text;
        if(!string.IsNullOrEmpty(username)){
            myButton.interactable = true;
        }
        else
            myButton.interactable = false;
    }
}
