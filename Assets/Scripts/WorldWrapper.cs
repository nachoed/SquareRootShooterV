using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldWrapper : MonoBehaviour
{
    public int mapWidth;
    public int mapHeight;

    public bool isWrapping;

    void LateUpdate()
    {
        Vector3 pos = transform.position;


        if (isWrapping)
        {
            // if we are reach the x boundary of the map, wrap the position back to 0 
            // using the map dimension
            if (pos.x > mapWidth)
            {
                pos.x -= mapWidth;
            }
            else if (pos.x < 0f)
            {
                pos.x += mapWidth;
            }

            // we do the same thing for y
            if (pos.y > mapHeight)
            {
                pos.y -= mapHeight;
            }
            else if (pos.y < 0f)
            {
                pos.y += mapHeight;
            }

        }
        else
        {
            pos.x = Mathf.Max(Mathf.Min(pos.x, mapWidth), 0);
            pos.y = Mathf.Max(Mathf.Min(pos.y, mapHeight), 0);
        }


        // setting the transform position. Consider using local position when possible
        transform.position = pos;
    }
}
