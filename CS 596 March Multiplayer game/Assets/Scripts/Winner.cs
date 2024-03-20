using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;
using UnityEngine.Networking;

public class Winner : MonoBehaviour
{
    public BoxCollider2D collider;
    public GameObject GameOver;

    public AudioSource victory;
    private void OnTriggerEnter2D(Collider2D other)
    {
        victory.Play();
        GameOver.SetActive(true);
    }
}
