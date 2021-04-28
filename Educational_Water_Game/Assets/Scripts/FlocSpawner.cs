using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlocSpawner : MonoBehaviour
{
    public GameObject spawnableObject;

    private float timer = 5;
    private float minSpawnDelay = 1;
    private float maxSpawnDelay = 3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer -= 1 * Time.deltaTime;
        if(timer <= 0)
        {
            int side = Random.Range(1, 5);
            switch (side)
            {
                case 1:
                    Instantiate(spawnableObject, new Vector3(-10, Random.Range(-5, 5), 0), Quaternion.identity);
                    break;
                case 2:
                    Instantiate(spawnableObject, new Vector3(10, Random.Range(-5, 5), 0), Quaternion.identity);
                    break;
                case 3:
                    Instantiate(spawnableObject, new Vector3(Random.Range(-10, 10), -6, 0), Quaternion.identity);
                    break;
                case 4:
                    Instantiate(spawnableObject, new Vector3(Random.Range(-10, 10), 6, 0), Quaternion.identity);
                    break;
                default:
                    Instantiate(spawnableObject, new Vector3(-10, Random.Range(-5, 5), 0), Quaternion.identity);
                    break;
            }
            timer = Random.Range(minSpawnDelay, maxSpawnDelay);
        }
        
    }
}
