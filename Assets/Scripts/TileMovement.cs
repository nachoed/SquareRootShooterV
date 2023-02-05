using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileMovement : MonoBehaviour
{

    public TileController tileController;
    public Transform shipTransform;
    //Transform tileStartPosition;
    Vector3 targetPosition;
    public float speed;
    //public Collider2D collider2D;
    public GameObject player;
    public bool isPermanent;
    public AudioSource audioSource;
    public AudioClip destroyTile;
    public AudioClip destroyShip;

    public void MoveToShipCenter()
    {
        Debug.Log("MoveToShipCenter");
        //tileStartPosition = this.transform;
        targetPosition = shipTransform.position;
        //transform.Translate(shipTransform.position * Time.deltaTime, shipTransform);
        if(this.gameObject.activeSelf)
            StartCoroutine(MoveTilesOverTime());
    }

    IEnumerator MoveTilesOverTime()
    {
        while (Vector3.Distance(transform.position, targetPosition) > 0.1f)
        {
            yield return null;
            //Debug.Log("In Loop");
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
        }

        //for (int i = 0; i < tileController.tiles.Count; i++)
        //{
        //    //tileController.tiles[i].transform.position = tileStartPosition.position;
        //    tileController.tiles[i].SetActive(false);
            
        //}
        
        tileController.ReactivateTiles();

        yield break;
    }

    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    if(collision.gameObject.tag == "Pick Up")
    //    {
    //        Destroy(collision.gameObject);
    //        tileController.AddTileToShip();
    //    }
    //}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Pick Up")
        {
            Destroy(collision.gameObject);
            tileController.AddTileToShip();
        }

        if (collision.gameObject.tag == "Obstacle")
        {
            Destroy(collision.gameObject);
            if (isPermanent)
            {
                audioSource.clip = destroyShip;
                audioSource.Play();

                player.SetActive(false);
                //GAME OVER
            }
            else
            {
                audioSource.clip = destroyTile;
                audioSource.Play();

                this.gameObject.SetActive(false);
            }
            
        }
    }

}
