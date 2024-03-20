using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEditor;
using UnityEngine;

public class BasicMovement : NetworkBehaviour
{
    [Header("REFERENCES")]
    [SerializeField] private Rigidbody2D rb;
    
    [Header("MOVEMENT SETTINGS")]
    [SerializeField] private float speed;
    [SerializeField] private float jumpForce;

    [Header("GROUND CHECKING")]
    [SerializeField] private LayerMask ground;
    [SerializeField] private float rayLength;
    [SerializeField] private bool grounded;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        // If you're not the owner of THIS instance of the script, don't do anything
        if (!IsOwner) return;
        
        // Get horizontal desired movement. Apply it
        float horizontal = Input.GetAxisRaw("Horizontal") * speed;
        rb.velocity = new Vector2(horizontal, rb.velocity.y);

        grounded = Physics2D.Raycast(transform.position, Vector2.down, rayLength, ground);
        
        // If the player pressed space and is grounded, jump
        if (Input.GetKey(KeyCode.Space) && grounded)
        {
            rb.velocity = Vector2.up * jumpForce;
        }
    }
}
