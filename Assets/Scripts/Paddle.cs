using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{

    Rigidbody2D rb;
    public float moveSpeed;


    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        //Debug.Log("Rigidbody2D initialized and constraints set.");
    }

    // Start is called before the first frame update
    void Start()
    {
       // Debug.Log("Paddle script started.");

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        TouchMove();
        //Debug.Log("touched");
    }

    void TouchMove()
    {
        if(Input.GetMouseButton(0))
        {
            Vector2 touchPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            //Debug.Log("Mouse button held down. Touch position: " + touchPos);

            if (touchPos.x < 0)
            {
                //move left

                rb.velocity = Vector2.left * moveSpeed;
                //Debug.Log("Moving left. Velocity: " + rb.velocity);

            }
            else //if (touchPos.x > 0)
            {
                //move right
                rb.velocity = Vector2.right * moveSpeed;
                //Debug.Log("Moving right. Velocity: " + rb.velocity);

            }
        }
        //when not clicking
        else
        {
            rb.velocity = Vector2.zero;
        }


    }
}
