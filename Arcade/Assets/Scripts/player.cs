using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    
    Transform t;
    Rigidbody2D rb;
    public float speed;
    public Vector2 jumpHeight;
    public Animator animator;
    void Start()
    {
        t = GetComponent<Transform>();
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        float mx=Input.GetAxis("Horizontal");
        float gx=Input.GetAxis("Vertical");

        animator.SetFloat("HorizontalAxis", mx);

        if (mx > 0f) {
            rb.velocity = new Vector2 (mx * speed, rb.velocity.y);
        }
        else if (mx < 0f) {
            rb.velocity = new Vector2 (mx * speed, rb.velocity.y);
        } 
        else {
            rb.velocity = new Vector2 (0,rb.velocity.y);
        }

        // transform.Translate(speed * Time.deltaTime, 0f, 0f);  //makes player run

        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))  //makes player jump
        {
            GetComponent<Rigidbody2D>().AddForce(jumpHeight, ForceMode2D.Impulse);
        }
    }
}
