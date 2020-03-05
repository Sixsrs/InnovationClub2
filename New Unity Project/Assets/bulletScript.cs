using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletScript : MonoBehaviour
{
    int timer = 0;
    public float speed = 1f;
    bool continueS = false;
    Vector2 myVel = new Vector2(0f, 0f);
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //continueS = true;
        
        if (Input.GetMouseButtonDown(0)) {
            myVel = myVel + new Vector2( (transform.position.x - Input.mousePosition.x)/200, speed);
            continueS = true;
        } 
        if (continueS)
        {
            timer = timer + 1;
            
        }
        if (timer > 100)
        {
            myVel = new Vector2(0f, 0f);
        }
        
//        if (Input.GetMouseButtonDown(1)) {
//            if (continueS) {
//                myVel = myVel + new Vector2(0f, -1 * speed);
//                myVel = new Vector2(0f, 0f);
//                }
//        } 
        
        
        
        rb.position = rb.position + myVel * .01f;
    }
    
}
