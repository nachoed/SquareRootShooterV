using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShipBodyCollider : MonoBehaviour
{
    
    public TileController tileController;
    public AudioSource audioSource;
    public AudioClip destroyShip;
    public GameObject destroyParticles;

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

            GameOver();

            gameObject.SetActive(false);
            //GAME OVER
        }
    }

    public void GameOver()
    {
        audioSource.clip = destroyShip;
        audioSource.Play();

        Instantiate(destroyParticles, transform.position, Quaternion.identity);

        transform.parent.gameObject.GetComponent<ShipControls>().LoadMenuScene();
    }

    
}
