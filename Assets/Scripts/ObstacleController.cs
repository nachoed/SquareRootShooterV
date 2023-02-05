using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleController : MonoBehaviour
{
    GameObject shipGO;
    public float speed;
    public float distance;
    public float splitTimer;
    public GameObject obstacle;
    RaycastHit2D raycastHitUp;
    RaycastHit2D raycastHitDown;
    RaycastHit2D raycastHitLeft;
    RaycastHit2D raycastHitRight;

    // Start is called before the first frame update
    void Start()
    {
        shipGO = GameObject.FindGameObjectWithTag("Main Ship");
        StartCoroutine(EnemySplit());
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, shipGO.transform.position) < distance)
            transform.position = Vector3.MoveTowards(transform.position, shipGO.transform.position, speed * Time.deltaTime);

        raycastHitUp = Physics2D.Raycast(transform.position, Vector2.up, 4f);
        raycastHitDown = Physics2D.Raycast(transform.position, Vector2.down, 4f);
        raycastHitLeft = Physics2D.Raycast(transform.position, Vector2.left, 4f);
        raycastHitRight = Physics2D.Raycast(transform.position, Vector2.right, 4f);

        if(raycastHitUp.collider.gameObject.tag == "Main Ship")
        {
            Debug.Log("HIT SOMETHING");
        }



    }

    IEnumerator EnemySplit()
    {
        while (true)
        {
            yield return new WaitForSeconds(splitTimer);
            Vector3 spawnPosition = transform.position;
            spawnPosition.y = transform.position.y + Random.Range(-1, +1);
            spawnPosition.x = transform.position.x + Random.Range(-1, +1);
            Instantiate(obstacle, spawnPosition, Quaternion.identity);
        }
        
    }
}
