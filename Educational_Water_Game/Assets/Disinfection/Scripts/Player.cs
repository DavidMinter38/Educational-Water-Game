using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{

    public GameObject bulletPrefab;
    public GameObject bulletParent;

    public Queue<GameObject> bulletQueue = new Queue<GameObject>();

    public int bulletQueueSize = 50;

    private float yAxisPos = -5.23f;

    public int score = 0;

    public Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        createBulletQueue(bulletQueueSize);
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 mouse = new Vector3(Input.mousePosition.x, Input.mousePosition.y, -Camera.main.transform.position.z);
        mouse = Camera.main.ScreenToWorldPoint(mouse);

        this.transform.position = new Vector2(mouse.x, mouse.y);
        

    }

    public void setScore(int value)
    {
        score = value;
        scoreText.text = "Score: " + score;
    }

    void OnMouseDown()
    {
        shoot();
    }

    void shoot()
    {

        print("Shoot");

        GameObject bullet = bulletQueue.Dequeue();

        bullet.transform.position = transform.position;

        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(new Vector2(-1000, 0));

        bulletQueue.Enqueue(bullet);
    }

    void createBulletQueue(int amount)
    {
        for (int x = 0; x < amount; x++)
        {
            GameObject tempBullet = Instantiate(bulletPrefab, bulletParent.transform);
            tempBullet.transform.position = new Vector2(100000, 0);
            tempBullet.GetComponent<Bullet>().player = this;
            bulletQueue.Enqueue(tempBullet);
        }
    }

    public void deleteBulletQueue()
    {
        for (int x = 0; x < bulletQueueSize; x++)
        {
            GameObject bullet = bulletQueue.Dequeue();
            Destroy(bullet);
        }
    }
}
