using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Characters : MonoBehaviour
{


    protected Rigidbody2D body;
    public float jumpForce = 1;


    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    protected void Jump()
    {
        body.AddForce(new Vector2(0,jumpForce));
    }




    void Health()
    {

    }



}
