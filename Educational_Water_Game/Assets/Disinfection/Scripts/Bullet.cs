using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public Player player;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {


        
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag != "Bullet" && collision.gameObject.tag != "Player" && collision.gameObject.tag == "Enemy")
        {
            
            transform.position = new Vector2(100000, 0);
            player.setScore(player.score + 1);
            collision.GetComponent<Enemy>().respawn();
        }
    }
}
