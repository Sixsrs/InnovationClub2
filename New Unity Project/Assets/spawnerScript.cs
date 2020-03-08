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
            Instantiate(enemy, new Vector3(0f, 0f, 0f), Quaternion.identity);
        }
        
    }
}
