using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipControls : MonoBehaviour
{

    public Rigidbody2D rb2D;
    bool forceOn = false;
    public float forceAmount = 10.0f;
    float torquDirection = 0.0f;
    public float torqueAmount = 0.5f;
    public float minClampRange;
    public float maxClampRange;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        forceOn = Input.GetKey(KeyCode.W);

        if (Input.GetKeyDown(KeyCode.S))
        {
            //transform.RotateAround(transform.position, new Vector3(0, 0, 1), 180.0f);
            Debug.Log("CAN'T SLOW DOWN!!!");
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

        //WrapAroundBoundary();
        ClampInBoundary();
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

        if (x > 62f)
        {
            x = x - 122f;
        }

        if (x < -62f)
        {
            x = x + 122f;
        }

        if (y > 62f)
        {
            y = y - 122f;
        }

        if (y < -62f)
        {
            y = y + 122f;
        }

        transform.position = new Vector2(x, y);
    }

    void ClampInBoundary()
    {
        Vector3 v3 = transform.position;
        v3.x = Mathf.Clamp(v3.x, minClampRange, maxClampRange);
        v3.y = Mathf.Clamp(v3.y, minClampRange, maxClampRange);
        transform.position = v3;
    }
}
