using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAround : MonoBehaviour
{
    public float rotSpeed = 2f;
    public KeyCode key;

    float rot = 0;
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rot += rotSpeed;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rotSpeed = -rotSpeed;
        }
    }

    void FixedUpdate()
    {
        rb.MoveRotation(rot);
    }
}
