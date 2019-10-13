using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemys : Characters 
{

    public float speed;
    public float stoppingdistance;
    public float retreatdistance;

    public Transform player;

    void Start()
    {
        

        player = GameObject.FindGameObjectWithTag("herotag").transform;
        


    }

    // Update is called once per frame
    void Update()
    {

        if(Vector2.Distance(transform.position, player.position) > stoppingdistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
        } else if (Vector2.Distance(transform.position, player.position) < stoppingdistance && Vector2.Distance(transform.position, player.position)> retreatdistance) {

            transform.position = this.transform.position;
        } else if(Vector2.Distance(transform.position, player.position) < retreatdistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.position, -speed * Time.deltaTime);
        }




    }
}
