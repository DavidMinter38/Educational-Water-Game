using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{


    public float speed = 0.01f;

    float maxHeight = 0;

    [HideInInspector]
    public EnemyController ec;

    // Start is called before the first frame update
    void Start()
    {
        maxHeight = 4;//Camera.main.ScreenToWorldPoint(new Vector2(0, Camera.main.pixelHeight)).y;
        speed = Random.RandomRange(0.09f, 0.11f);
        respawn();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(transform.position.x + speed, transform.position.y);
        Vector2 screenPos = Camera.main.WorldToScreenPoint(transform.position);
        if (screenPos.x > Camera.main.scaledPixelWidth)
        {
            //respawn();
            ec.gameOver();
        }
    }

    public void respawn()
    {
        float randomY = Random.RandomRange(-maxHeight, maxHeight);
        float randomX = Random.RandomRange(-100, -10);
        transform.position = new Vector2(randomX, randomY);
        speed += 0.01f;
    }
}
