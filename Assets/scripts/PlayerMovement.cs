using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public float jump;
    float move;

    Rigidbody2D rb;
    public bool isJumping;

    // Start is called before the first frame update
    void Start()
    {
        speed = 10f;
        jump = 400f;
        rb = GetComponent<Rigidbody2D>(); 
        
    }

    // Update is called once per frame
    void Update()
    {
        move = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(speed * move, rb.velocity.y);

        if(Input.GetButtonDown("Jump") && !isJumping)
        {
            Debug.Log("Space");
            rb.AddForce(new Vector2(rb.velocity.x, jump));
            isJumping = true;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Ground"))
        {
            isJumping=false;    
        }
    }
}
