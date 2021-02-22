﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAndMoveForward : MonoBehaviour
{
    public float rotSpeed = 1f;
    Rigidbody2D rb;
    float rot = 0;
    

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rot += rotSpeed;
        rb.MoveRotation(rot);

        if (Input.GetKey(KeyCode.W))
		{
            rb.velocity = transform.up * 2f;
		}
		else
		{
            rb.velocity = Vector2.zero;
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            rotSpeed = -rotSpeed;
        }
    }
}
