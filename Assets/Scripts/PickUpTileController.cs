using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpTileController : MonoBehaviour
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
        if(shipGO != null)
            if(Vector3.Distance(transform.position, shipGO.transform.position) < distance)
                transform.position = Vector3.MoveTowards(transform.position, shipGO.transform.position, -1 * speed *Time.deltaTime);
    }
}
