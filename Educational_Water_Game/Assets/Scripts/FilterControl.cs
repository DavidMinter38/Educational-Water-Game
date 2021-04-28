using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FilterControl : MonoBehaviour
{
    Rigidbody2D filterRigidBody;

    public int filterSpeed = 5;

    // Start is called before the first frame update
    void Start()
    {
        filterRigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        filterRigidBody.transform.position += new Vector3(Input.GetAxis("Horizontal") * filterSpeed * Time.deltaTime, 0, 0);
    }
}
