using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NetworkManagerUI : MonoBehaviour
{
    [SerializeField] private Button serverBtn;
    [SerializeField] private Button hostBtn;
    [SerializeField] private Button clientBtn;

    [SerializeField] private GameObject Goal;
    [SerializeField] private GameObject Maze;

    private void Awake()
    {
        // When button is clicked
        // - Enable the goal and Maze
        // - Disable the choice UI
        // AND...
        
        // - Start server
        serverBtn.onClick.AddListener(() =>
        {
            Goal.SetActive(true);
            Maze.SetActive(true);
            gameObject.SetActive(false);
            NetworkManager.Singleton.StartServer();
        });
        // - Start host
        hostBtn.onClick.AddListener(() => {
            Goal.SetActive(true);
            Maze.SetActive(true);
            gameObject.SetActive(false);
            NetworkManager.Singleton.StartHost();
        });
        // - Start client
        clientBtn.onClick.AddListener(() => { 
            Goal.SetActive(true);
            Maze.SetActive(true);
            gameObject.SetActive(false);
            NetworkManager.Singleton.StartClient();
        });
    }
}
