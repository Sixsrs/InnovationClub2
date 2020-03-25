﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wolfScript : MonoBehaviour
{
    public int sightRadius = 10;
    public int attackRadius = 7;
    public int stopRadius = 6;
    public float speed = .03f;
    int attackTimer = 0;
    public GameObject player;
    float magnitude;
    // Start is called before the first frame update
    void Start()
    {

        player = GameObject.Find("pixel-8x8");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        magnitude = Mathf.Pow(Mathf.Pow(player.transform.position.x - transform.position.x, 2) + Mathf.Pow(player.transform.position.y - transform.position.y, 2f), .5f);
        if (magnitude < sightRadius)
        {
            transform.position = new Vector2(transform.position.x + (player.transform.position.x - transform.position.x) * speed / magnitude, transform.position.y + (player.transform.position.y - transform.position.y) * speed / magnitude);
        }
        if (magnitude < attackRadius)
        {

            
            if (attackTimer == 0)
            {
                attackTimer = 195;
                speed = 0f;
            }
            else if (attackTimer == 180)
            {
                speed = .12f;
            }
            else if (attackTimer == 120)
            {
                speed = .06f;
            }
            attackTimer--;
        }
        
        
    }
}
