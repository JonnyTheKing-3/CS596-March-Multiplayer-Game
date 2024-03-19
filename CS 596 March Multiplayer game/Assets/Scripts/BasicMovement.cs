using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class BasicMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed;
    public float jumpForce;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // Get horizontal desired movement. Apply it
        float horizontal = Input.GetAxisRaw("Horizontal") * speed;
        rb.velocity += Vector2.right * horizontal;
        
        // If the player pressed space, jump
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity += Vector2.up * jumpForce;
        }
    }
}
