using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressCount : MonoBehaviour
{
    public KeyCode KeyToPress = KeyCode.Space;
    public int Counter;
    
    void Update()
    {
        if (Input.GetKeyDown(KeyToPress))
        {
            ++Counter;
        }
    }
}
