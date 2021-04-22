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
        scraperRigidBody.transform.Rotate(0, 0, Input.GetAxis("Horizontal")/2);
    }
}
