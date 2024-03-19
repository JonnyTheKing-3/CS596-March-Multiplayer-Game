using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickARandomLetter : MonoBehaviour
{
    void Start()
    {
        for (int i = 0; i < 10; i++) 
        {
            // Generate a random keycode from A to Z
            int randomKeyCode = Random.Range((int)KeyCode.A, (int)KeyCode.Z + 1);
    
            // Get the corresponding letter from the keycode
            char randomLetter = (char)randomKeyCode;
    
            // Print the randomly chosen letter
            Debug.Log("Random Letter: " + randomLetter);
        }
    }
}
