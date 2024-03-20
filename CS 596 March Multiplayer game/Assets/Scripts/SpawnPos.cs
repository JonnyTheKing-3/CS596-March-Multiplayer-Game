using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;

public class SpawnPos : NetworkBehaviour
{
    public Transform left;
    public Transform right;
    void Start()
    {
        left = GameObject.Find("LeftStartingPos").transform;
        right = GameObject.Find("RightStartingPos").transform;
        
        if (IsHost)
        {
            transform.position = left.position;
        }
        if (IsClient)
        {
            transform.position = right.position;
        }
    }
}
