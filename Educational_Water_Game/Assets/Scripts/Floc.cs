using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floc : MonoBehaviour
{
    private GameObject targetObject;

    // Start is called before the first frame update
    void Start()
    {
        targetObject = FindObjectOfType<ScraperControl>().gameObject;
        if(targetObject == null)
        {
            Debug.LogError("Cannot find target object");
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, targetObject.transform.position, 1.0f * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            FindObjectOfType<Stage3Manager>().AddToScore();
        }
        Destroy(gameObject);
    }
}
