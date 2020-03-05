using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public float speed = 1f;
    Vector2 myVel = new Vector2(0f, 0f);
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("w"))
        {
            myVel = myVel + new Vector2(0f, speed);
        }
        if (Input.GetKeyDown("s"))
        {
            myVel = myVel + new Vector2(0f, -1f * speed);
        }
        if (Input.GetKeyDown("a"))
        {
            myVel = myVel + new Vector2(-1 * speed, 0f);
        }
        if (Input.GetKeyDown("d"))
        {
            myVel = myVel + new Vector2(speed, 0f);
        }

        if (Input.GetKeyUp("w"))
        {
            myVel = myVel + new Vector2(0f, speed * -1f);
        }
        if (Input.GetKeyUp("s"))
        {
            myVel = myVel + new Vector2(0f, speed);
        }
        if (Input.GetKeyUp("a"))
        {
            myVel = myVel + new Vector2(speed, 0f);
        }
        if (Input.GetKeyUp("d"))
        {
            myVel = myVel + new Vector2(-1 * speed, 0f);
        }
        rb.position = rb.position + myVel * .01f;
    }
}
