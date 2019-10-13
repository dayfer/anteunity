using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract public class Characters : MonoBehaviour
{
    protected Rigidbody2D rBody;
    protected Vector2 jumpAngle = new Vector2(0.1f, 1f);
    protected float jumpForce = 3000f;

    // Start is called before the first frame update
    public void Start()
    {
        rBody = GetComponent<Rigidbody2D>();
        rBody.mass = 10f;
        rBody.freezeRotation = true;
    }

    // Update is called once per frame
    void Update()
    {

    }

    protected void Jump()
    {
        print(jumpAngle);
        print(jumpAngle * jumpForce);
        rBody.AddForce(jumpAngle* jumpForce);
    }




    void Health()
    {

    }



}
