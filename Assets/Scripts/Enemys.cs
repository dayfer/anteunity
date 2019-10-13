using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemys : Characters 
{

    public float speed = 1;
    public float stoppingdistance = 1;
    public float retreatdistance = 3;
    float retreatSpeed;
    float attackSpeed;

    public Transform player;

    void Start()
    {
        base.Start();
        player = GameObject.FindGameObjectWithTag("herotag").transform;
        print(player);
    }
    void FixedUpdate()
    {

    }
    // Update is called once per frame
    void Update()
    {
        stoppingdistance = 3;
        retreatdistance = 1;
        retreatSpeed = 100;
        attackSpeed = 1;

        if (Vector2.Distance(transform.position, player.position) > stoppingdistance)
        {

            //The Hero Player is too far away! Let's follow!
            print(Vector2.Distance(transform.position, player.position));
            print(speed);
            transform.position = Vector2.MoveTowards(transform.position, player.position, attackSpeed * Time.deltaTime);
        } else if (Vector2.Distance(transform.position, player.position) < stoppingdistance && Vector2.Distance(transform.position, player.position)> retreatdistance)
        {

            //why is this needed?
           // transform.position = this.transform.position;
        } else if(Vector2.Distance(transform.position, player.position) < retreatdistance)
        {
            //The Hero Player is too clolse! Let's leave!
            print(Vector2.Distance(transform.position, player.position));
            print(speed);
            transform.position = Vector2.MoveTowards(transform.position, player.position, -retreatSpeed * Time.deltaTime*0.1f);
        }


    }
}
