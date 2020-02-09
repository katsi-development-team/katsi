using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement2 : MonoBehaviour
{

    public float moveSpeed = 3f;

    public Rigidbody2D rb;

    //Vector2 means it will store horizontal and vertical
    Vector2 movement;
    float angle;

    /* Do NOT use the built-in update function for anythig physics related !!!!!
     * Useful for registering input instead
     */
    void Update()
    {

        /* Will give either 1 or -1, depending on horizontal input
         * Left = -1, Right = 1, Pressing nothing returns 0
         */
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }


    /* Executed on fixed timer, unlike Update() which is stuck to the client framerate
     * Called 50 times a second
     */
    private void FixedUpdate()
    {

        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    
    }
}
