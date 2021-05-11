using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScraperControl : MonoBehaviour
{
    Rigidbody2D scraperRigidBody;

    // Start is called before the first frame update
    void Start()
    {
        scraperRigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("left"))
        {
            scraperRigidBody.transform.Rotate(0, 0, 0.2f);
        } else if (Input.GetKey("right"))
        {
            scraperRigidBody.transform.Rotate(0, 0, -0.2f);
        }
    }
}
