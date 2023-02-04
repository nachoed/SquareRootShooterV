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

    public void MoveToShipCenter()
    {
        Debug.Log("MoveToShipCenter");
        //tileStartPosition = this.transform;
        targetPosition = shipTransform.position;
        //transform.Translate(shipTransform.position * Time.deltaTime, shipTransform);
        StartCoroutine(MoveTilesOverTime());
    }

    IEnumerator MoveTilesOverTime()
    {
        while (Vector3.Distance(transform.position, targetPosition) > 0.1f)
        {
            yield return null;
            Debug.Log("In Loop");
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
        }

        for (int i = 0; i < tileController.tiles.Count; i++)
        {
            //tileController.tiles[i].transform.position = tileStartPosition.position;
            tileController.tiles[i].SetActive(false);
            
        }
        
        yield break;
    }

}
