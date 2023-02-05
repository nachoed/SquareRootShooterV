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

    public GameObject skinA;
    public GameObject skinB;
    public GameObject skinC;
    public GameObject skinD;
    public GameObject skinE;

    // Start is called before the first frame update
    void Start()
    {
        int skinPicker = Random.Range(1, 5);

        switch (skinPicker)
        {
            case 1:
                skinA.SetActive(true);
                break;

            case 2:
                skinB.SetActive(true);
                break;

            case 3:
                skinC.SetActive(true);
                break;

            case 4:
                skinD.SetActive(true);
                break;

            case 5:
                skinE.SetActive(true);
                break;
            default:
                break;
        }

        shipGO = GameObject.FindGameObjectWithTag("Main Ship");
        StartCoroutine(EnemySplit());
    }

    // Update is called once per frame
    void Update()
    {
        if(shipGO != null)
            if (Vector3.Distance(transform.position, shipGO.transform.position) < distance)
                transform.position = Vector3.MoveTowards(transform.position, shipGO.transform.position, speed * Time.deltaTime);

        //raycastHitUp = Physics2D.Raycast(transform.position, Vector2.up, 4f);
        //raycastHitDown = Physics2D.Raycast(transform.position, Vector2.down, 4f);
        //raycastHitLeft = Physics2D.Raycast(transform.position, Vector2.left, 4f);
        //raycastHitRight = Physics2D.Raycast(transform.position, Vector2.right, 4f);

        //if(raycastHitUp.collider.gameObject.tag == "Main Ship")
        //{
        //    Debug.Log("HIT SOMETHING");
        //}

        //Collider2D distanceCheck = Physics2D.OverlapCircle(transform.position, 4f,)



    }

    public void MoveAway(Vector3 v3)
    {
        StartCoroutine(MoveAwayTimer(v3));
    }

    IEnumerator MoveAwayTimer(Vector3 v3)
    {
        
        yield return null;
        transform.position = Vector3.MoveTowards(transform.position, v3, -1 * speed * Time.deltaTime);
        
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
            MoveAway(spawnPosition);
        }
        
    }
}
