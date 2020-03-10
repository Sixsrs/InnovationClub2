using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnerScript : MonoBehaviour
{
    int timer = 0;
    public Object enemy;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += 1;
        if ((timer % 30) == 0)
        {
            Instantiate(enemy, new Vector3(Random.Range(transform.position.x - transform.localScale.x/2f, transform.position.x + transform.localScale.x/2f), Random.Range(transform.position.y - transform.localScale.y / 2f, transform.position.y + transform.localScale.y / 2f), 0f), Quaternion.identity);
        }
        
    }
}
