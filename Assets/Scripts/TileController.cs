using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileController : MonoBehaviour
{

    public List<GameObject> tiles = new List<GameObject>();
    public List<GameObject> tilePositions = new List<GameObject>();

    void Start()
    {
        foreach (var go in tiles)
        {
            go.SetActive(false);
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            foreach (var go in tiles)
            {
                go.GetComponent<TileMovement>().MoveToShipCenter();
            }
        }
        
        if (Input.GetKeyDown(KeyCode.T))
        {
            AddTileToShip();
        }
    }

    void AddTileToShip()
    {
        

        for (int i = 0; i < tiles.Count; i++)
        {
            if (!tiles[i].activeSelf)
            {
                tiles[i].SetActive(true);
                tiles[i].transform.position = tilePositions[i].transform.position;
                Debug.Log("Setting " + tiles[i] + " to active");
                break;
            }
            else
            {
                Debug.Log(tiles[i] + " is already active");
            }
        }
    }

}
