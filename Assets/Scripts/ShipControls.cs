using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipControls : MonoBehaviour
{

    public Rigidbody2D rb2D;
    bool forceOn = false;
    public float forceAmount = 10.0f;
    public float torquDirection = 0.0f;
    public float torqueAmount = 0.5f;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        forceOn = Input.GetKey(KeyCode.W);

        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.RotateAround(transform.position, new Vector3(0, 0, 1), 180.0f);
        }

        if (Input.GetKey(KeyCode.A))
        {
            torquDirection = 1f;
        } 
        else if (Input.GetKey(KeyCode.D))
        {
            torquDirection = -1f;
        }
        else
        {
            torquDirection = 0;
        }


    }

    private void FixedUpdate()
    {
        if (forceOn)
        {
            rb2D.AddForce(transform.up * forceAmount);
        }

        if(torquDirection != 0)
        {
            rb2D.AddTorque(torquDirection * torqueAmount);
        }
    }

    void WrapAroundBoundary()
    {
        float x = transform.position.x;
        float y = transform.position.y;

        if (x > 8f)
        {
            x = x - 16f;
        }

        if (x < -8f)
        {
            x = x + 16f;
        }

        if (y > 4.5f)
        {
            y = y - 9f;
        }

        if (y < -4.5f)
        {
            y = y + 9f;
        }

        transform.position = new Vector2(x, y);
    }
}
