using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipBodyCollider : MonoBehaviour
{
    
    public TileController tileController;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Pick Up")
        {
            Destroy(collision.gameObject);
            tileController.AddTileToShip();
        }

        if(collision.gameObject.tag == "Obstacle")
        {
            Destroy(collision.gameObject);
            transform.parent.gameObject.SetActive(false);
        }
    }
}
