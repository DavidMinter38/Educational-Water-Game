using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterSpawner : MonoBehaviour
{
    public GameObject spawnableObject;

    private float timer = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer -= 1 * Time.deltaTime;
        if (timer <= 0)
        {
            Instantiate(spawnableObject, new Vector3(Random.Range(-7, 7), 8, 0), Quaternion.identity);
            timer = 2;
        }
    }
}
