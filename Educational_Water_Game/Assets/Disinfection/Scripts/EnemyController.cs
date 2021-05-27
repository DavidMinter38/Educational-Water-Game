using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyController : MonoBehaviour
{
    public GameObject enemyPrefab;
    public GameObject enemyParent;

    public Queue<GameObject> enemyQueue = new Queue<GameObject>();

    public int enemyQueueSize = 25;

    public Player player;

    public GameObject gameOverScreen;
    public Text gameOverScore;

    // Start is called before the first frame update
    void Start()
    {
        createEnemyQueue(enemyQueueSize);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void createEnemyQueue(int amount)
    {
        for (int x = 0; x < amount; x++)
        {
            GameObject tempEnemy = Instantiate(enemyPrefab, enemyParent.transform);
            
            tempEnemy.GetComponent<Enemy>().ec = this;
            enemyQueue.Enqueue(tempEnemy);
        }
    }

    void deleteEnemyQueue()
    {
        for (int x = 0; x < enemyQueueSize; x++)
        {
            GameObject enemy = enemyQueue.Dequeue();
            Destroy(enemy);
        }
    }

    public void gameOver()
    {
        print("Game Over");
        deleteEnemyQueue();
        player.deleteBulletQueue();

        gameOverScreen.SetActive(true);
        gameOverScore.text = "Score: " + player.score;

        Destroy(player.scoreText.gameObject);
        Destroy(player.gameObject);
    }
}
