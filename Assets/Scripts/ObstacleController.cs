using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleController : MonoBehaviour
{
    GameObject shipGO;
    public float speed;
    public float distance;

    // Start is called before the first frame update
    void Start()
    {
        shipGO = GameObject.FindGameObjectWithTag("Main Ship");
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, shipGO.transform.position) < distance)
            transform.position = Vector3.MoveTowards(transform.position, shipGO.transform.position, speed * Time.deltaTime);
    }
}
