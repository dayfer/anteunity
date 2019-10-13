using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Characters
{
    // Start is called before the first frame update
    protected Rigidbody2D rb2d;
    protected SpriteRenderer spriteRenderer;

    void Start()
    {
        base.Start();
        rb2d = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void FixedUpdate()
    {

        if (Input.GetKey(KeyCode.A))
        {
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");

            spriteRenderer.flipX = false;

            Vector2 movement = new Vector2(moveHorizontal - 10f, moveVertical);
            rb2d.AddForce(movement * 10f);
            print(" movment ");
            print(movement);
        }
        if (Input.GetKey(KeyCode.D))
        {
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");

            spriteRenderer.flipX = true;
            Vector2 movement = new Vector2(moveHorizontal + 10f, moveVertical);
            rb2d.AddForce(movement * 10f);
            print(" movment ");
            print(movement);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();

        }


    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
