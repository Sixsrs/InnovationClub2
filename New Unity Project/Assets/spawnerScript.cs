using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnerScript : MonoBehaviour
{
    public int maxCapacity = 10;
    public int tenSecondSpawn = 5;
    public bool spawnWhenPlayerPresent = false;
    int timer = 0;
    int capacity = 0;
    public Object enemy;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("pixel-8x8");
        //PlayerScript playerScript = player.GetComponent<PlayerScript>();
       
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        timer += 1;
        if ((((timer % Mathf.Floor(300/tenSecondSpawn)) == 0) && capacity < maxCapacity) &&
           ((spawnWhenPlayerPresent) || 
           (player.transform.position.x+9f < (transform.position.x - transform.localScale.x / 2f)) ||
           (player.transform.position.x-9f > (transform.position.x + transform.localScale.x / 2f)) ||
           (player.transform.position.y+5.5f < (transform.position.y - transform.localScale.y / 2f)) ||
           (player.transform.position.y-5.5f > (transform.position.y + transform.localScale.y / 2f))


           ))
        {
            capacity++;
            Instantiate(enemy, new Vector3(Random.Range(transform.position.x - transform.localScale.x/2f, transform.position.x + transform.localScale.x/2f), Random.Range(transform.position.y - transform.localScale.y / 2f, transform.position.y + transform.localScale.y / 2f), 0f), Quaternion.identity);
        }
        
    }
}
