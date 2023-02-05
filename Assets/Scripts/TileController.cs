using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileController : MonoBehaviour
{

    public List<GameObject> tiles = new List<GameObject>();
    //public List<Vector3> tilePositions = new List<Vector3>();
    public List<Transform> tilePositions = new List<Transform>();
    public int levelCounter = 0;
    bool canLevelUp = false;

    void Start()
    {
        for (int i = 0; i < tiles.Count; i++)
        {
            tiles[i].SetActive(false);
            //tilePositions.Add(tiles[i].transform);
            //Debug.Log(tilePositions[i].position);
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && canLevelUp)
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

        switch (levelCounter)
        {
            case 0:
                if (!tiles[18-1].activeSelf)
                {
                    tiles[18-1].SetActive(true);
                }
                else if (!tiles[14-1].activeSelf)
                {
                    tiles[14 - 1].SetActive(true);
                }
                else if (!tiles[19 - 1].activeSelf)
                {
                    tiles[19 - 1].SetActive(true);
                    canLevelUp = true;
                }
                
                break;
            case 1:
                if (!tiles[18 - 1].activeSelf)
                {
                    tiles[18 - 1].SetActive(true);
                }
                else if (!tiles[14 - 1].activeSelf)
                {
                    tiles[14 - 1].SetActive(true);
                }
                else if (!tiles[12 - 1].activeSelf)
                {
                    tiles[12 - 1].SetActive(true);
                }
                else if (!tiles[19 - 1].activeSelf)
                {
                    tiles[19 - 1].SetActive(true);
                }
                else if (!tiles[17 - 1].activeSelf)
                {
                    tiles[17 - 1].SetActive(true);
                }
                else if (!tiles[9 - 1].activeSelf)
                {
                    tiles[9 - 1].SetActive(true);
                }
                else if (!tiles[7 - 1].activeSelf)
                {
                    tiles[7 - 1].SetActive(true);
                    canLevelUp = true;
                }
                break;
            case 2:
                if (!tiles[14 - 1].activeSelf)
                {
                    tiles[14 - 1].SetActive(true);
                }
                else if (!tiles[12 - 1].activeSelf)
                {
                    tiles[12 - 1].SetActive(true);
                }
                else if (!tiles[19 - 1].activeSelf)
                {
                    tiles[19 - 1].SetActive(true);
                }
                else if (!tiles[17 - 1].activeSelf)
                {
                    tiles[17 - 1].SetActive(true);
                }
                else if (!tiles[9 - 1].activeSelf)
                {
                    tiles[9 - 1].SetActive(true);
                }
                else if (!tiles[7 - 1].activeSelf)
                {
                    tiles[7 - 1].SetActive(true);
                }
                else if (!tiles[10 - 1].activeSelf)
                {
                    tiles[10 - 1].SetActive(true);
                }
                else if (!tiles[15 - 1].activeSelf)
                {
                    tiles[15 - 1].SetActive(true);
                }
                else if (!tiles[20 - 1].activeSelf)
                {
                    tiles[20 - 1].SetActive(true);
                }
                else if (!tiles[23 - 1].activeSelf)
                {
                    tiles[23 - 1].SetActive(true);
                }
                else if (!tiles[24 - 1].activeSelf)
                {
                    tiles[24 - 1].SetActive(true);
                }
                else if (!tiles[22 - 1].activeSelf)
                {
                    tiles[22 - 1].SetActive(true);
                }
                else if (!tiles[25 - 1].activeSelf)
                {
                    tiles[25 - 1].SetActive(true);
                    canLevelUp = true;
                }
                break;
            case 3:
                if (!tiles[18 - 1].activeSelf)
                {
                    tiles[18 - 1].SetActive(true);
                }
                else if (!tiles[14 - 1].activeSelf)
                {
                    tiles[14 - 1].SetActive(true);
                }
                else if (!tiles[12 - 1].activeSelf)
                {
                    tiles[12 - 1].SetActive(true);
                }
                else if (!tiles[19 - 1].activeSelf)
                {
                    tiles[19 - 1].SetActive(true);
                }
                else if (!tiles[17 - 1].activeSelf)
                {
                    tiles[17 - 1].SetActive(true);
                }
                else if (!tiles[9 - 1].activeSelf)
                {
                    tiles[9 - 1].SetActive(true);
                }
                else if (!tiles[7 - 1].activeSelf)
                {
                    tiles[7 - 1].SetActive(true);
                }
                else if (!tiles[10 - 1].activeSelf)
                {
                    tiles[10 - 1].SetActive(true);
                }
                else if (!tiles[15 - 1].activeSelf)
                {
                    tiles[15 - 1].SetActive(true);
                }
                else if (!tiles[20 - 1].activeSelf)
                {
                    tiles[20 - 1].SetActive(true);
                }
                else if (!tiles[23 - 1].activeSelf)
                {
                    tiles[23 - 1].SetActive(true);
                }
                else if (!tiles[24 - 1].activeSelf)
                {
                    tiles[24 - 1].SetActive(true);
                }
                else if (!tiles[22 - 1].activeSelf)
                {
                    tiles[22 - 1].SetActive(true);
                }
                else if (!tiles[25 - 1].activeSelf)
                {
                    tiles[25 - 1].SetActive(true);
                }
                else if (!tiles[3 - 1].activeSelf)
                {
                    tiles[3 - 1].SetActive(true);
                }
                else if (!tiles[4 - 1].activeSelf)
                {
                    tiles[4 - 1].SetActive(true);
                }
                else if (!tiles[2 - 1].activeSelf)
                {
                    tiles[2 - 1].SetActive(true);
                }
                
                else if (!tiles[11 - 1].activeSelf)
                {
                    tiles[11 - 1].SetActive(true);
                }
                else if (!tiles[16 - 1].activeSelf)
                {
                    tiles[16 - 1].SetActive(true);
                }
                
                else if (!tiles[6 - 1].activeSelf)
                {
                    tiles[6 - 1].SetActive(true);
                }
                else if (!tiles[21 - 1].activeSelf)
                {
                    tiles[21 - 1].SetActive(true);
                }
                else if (!tiles[5 - 1].activeSelf)
                {
                    tiles[5 - 1].SetActive(true);
                }
                else if (!tiles[1 - 1].activeSelf)
                {
                    tiles[1 - 1].SetActive(true);
                    canLevelUp = true;
                }
                break;
            case 4:
                break;
            default:
                break;
        }

        //for (int i = 0; i < tiles.Count; i++)
        //{
        //    if (!tiles[i].activeSelf)
        //    {
        //        tiles[i].SetActive(true);
        //        //tiles[i].transform.position = tilePositions[i].transform.position;
        //        Debug.Log("Setting " + tiles[i] + " to active");
        //        break;
        //    }
        //    else
        //    {
        //        Debug.Log(tiles[i] + " is already active");
        //    }
        //}
    }

    public void ReactivateTiles()
    {
        canLevelUp = false;
        Debug.Log("ReactivateTiles");
        levelCounter++;

        for (int i = 0; i < tiles.Count; i++)
        {
            Debug.Log(tilePositions[i].position);
            tiles[i].transform.position = tilePositions[i].position;
            Debug.Log(tiles[i].transform.position);
            tiles[i].SetActive(false);
        }
        
        switch (levelCounter)
        {
            case 0:
                
                break;
            case 1:
                tiles[8 - 1].SetActive(true);
                break;
            case 2:
                tiles[8 - 1].SetActive(true);
                tiles[18 - 1].SetActive(true);
                break;
            case 3:
                tiles[8 - 1].SetActive(true);
                tiles[12 - 1].SetActive(true);
                tiles[14 - 1].SetActive(true);
                break;
            case 4:
                tiles[8 - 1].SetActive(true);
                tiles[12 - 1].SetActive(true);
                tiles[14 - 1].SetActive(true);
                tiles[18 - 1].SetActive(true);
                break;
            default:
                break;
        }
    }

}
