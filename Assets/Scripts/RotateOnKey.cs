using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateOnKey : MonoBehaviour
{
    public KeyCode key;
    float speed = 5f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(key))
		{
            GetComponent<Rigidbody2D>().rotation = GetComponent<Rigidbody2D>().rotation + speed;

        }
    }
}
