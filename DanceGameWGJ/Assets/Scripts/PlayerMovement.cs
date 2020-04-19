using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movSpeed;
    private Rigidbody2D rb;
    public bool isGrounded = false; 

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    { 
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += movement * Time.deltaTime * movSpeed;   
        Jump();  
    }

    void Jump()
    {
        if(Input.GetButtonDown("Jump") && isGrounded == true){
            rb.AddForce(new Vector2(0f, 5f), ForceMode2D.Impulse);
        }
    }
}
