using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
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
            rb.velocity = rb.velocity + new Vector2(0f, 1f);
        }
        if (Input.GetKeyDown("s"))
        {
            rb.velocity = rb.velocity + new Vector2(0f, -1f);
        }
        if (Input.GetKeyDown("a"))
        {
            rb.velocity = rb.velocity + new Vector2(-1f, 0f);
        }
        if (Input.GetKeyDown("d"))
        {
            rb.velocity = rb.velocity + new Vector2(1f, 0f);
        }
    }
}
