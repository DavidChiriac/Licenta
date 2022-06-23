using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FocusInputField : MonoBehaviour
{
    InputField m_InputField;
    public Button button;
    void Start()
    {
        //Fetch the Input Field component from the GameObject
        m_InputField = GetComponent<InputField>();
        m_InputField.Select();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Return)){
            button.onClick.Invoke();
        }
    }
}
