using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private SpriteRenderer sr;

    public float movSpeed;
    public float jmpSpeed;
    public float dragSpeed;    
    public bool isGrounded = false;
    public Animator anim; 

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        rb.drag = dragSpeed;
        
    }

    
    void Update()
    { 
        Jump();
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f)  * movSpeed;
        transform.position += movement * Time.deltaTime;

        anim.SetFloat("speed", Mathf.Abs(Input.GetAxis("Horizontal") * movSpeed));

        if(Input.GetKeyDown("left"))
        {
            sr.flipX = false;
        } 

        if(Input.GetKeyDown("right"))
        {
            sr.flipX = true;
        }    
    }

    void Jump()
    {
        if(Input.GetButtonDown("Jump") && isGrounded == true){
           // rb.AddForce(new Vector2(0f, 5f), ForceMode2D.Impulse);
           rb.AddForce(transform.up * jmpSpeed, ForceMode2D.Impulse);
        }
    }
}
