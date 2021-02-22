using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDistOnHold : MonoBehaviour
{
    public Vector2 moveDist;
    public KeyCode key;
    Vector2 startPos;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        if (Input.GetKey(key))
        {
            GetComponent<Rigidbody2D>().MovePosition(startPos + moveDist);
        }
        else
		{
            GetComponent<Rigidbody2D>().MovePosition(startPos);
        }
    }
}
