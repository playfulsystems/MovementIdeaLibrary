using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateBothDirections : MonoBehaviour
{
    public KeyCode keyClockwise;
    public KeyCode keyCounterClockwise;
    float speed = 4f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(keyClockwise))
		{
            GetComponent<Rigidbody2D>().rotation = GetComponent<Rigidbody2D>().rotation - speed;

        }
        else if (Input.GetKey(keyCounterClockwise))
        {
            GetComponent<Rigidbody2D>().rotation = GetComponent<Rigidbody2D>().rotation + speed;

        }
    }
}
