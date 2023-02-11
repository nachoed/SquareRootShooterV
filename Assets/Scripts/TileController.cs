using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileController : MonoBehaviour
{

    public List<GameObject> tiles = new List<GameObject>();
    //public List<Vector3> tilePositions = new List<Vector3>();
    public List<Transform> tilePositions = new List<Transform>();
    int levelCounter = 0;
    bool canLevelUp = false;
    public AudioSource audioSource;
    public AudioClip collectTile;
    public AudioClip collapseShip;
    

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

    public void AddTileToShip()
    {

        audioSource.clip = collectTile;
        audioSource.Play();

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
                    StartCoroutine(LevelUpInTime());
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
                    StartCoroutine(LevelUpInTime());
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
                    StartCoroutine(LevelUpInTime());
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
                    StartCoroutine(LevelUpInTime());
                }
                break;
            case 4:
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
                    
                }
                break;
            default:
                break;
        }

    }

    public void ReactivateTiles()
    {
        canLevelUp = false;
        //Debug.Log("ReactivateTiles");
        levelCounter++;

        for (int i = 0; i < tiles.Count; i++)
        {
            //Debug.Log(tilePositions[i].position);
            tiles[i].transform.position = tilePositions[i].position;
            //Debug.Log(tiles[i].transform.position);
            tiles[i].SetActive(false);
        }
        
        switch (levelCounter)
        {
            case 0:
                
                break;
            case 1:
                tiles[8 - 1].SetActive(true);
                tiles[8 - 1].GetComponent<SpriteRenderer>().enabled = false;
                tiles[8 - 1].GetComponent <BoxCollider2D>().enabled = false;
                tiles[8 - 1].transform.GetChild(0).gameObject.SetActive(true);
                break;
            case 2:
                tiles[8 - 1].SetActive(true);
                tiles[8 - 1].GetComponent<SpriteRenderer>().enabled = false;
                tiles[8 - 1].GetComponent<BoxCollider2D>().enabled = false;
                tiles[8 - 1].transform.GetChild(0).gameObject.SetActive(true);

                tiles[18 - 1].SetActive(true);
                tiles[18 - 1].GetComponent<SpriteRenderer>().enabled = false;
                tiles[18 - 1].GetComponent<BoxCollider2D>().enabled = false;
                tiles[18 - 1].transform.GetChild(0).gameObject.SetActive(true);
                break;
            case 3:
                tiles[8 - 1].SetActive(true);
                tiles[8 - 1].GetComponent<SpriteRenderer>().enabled = false;
                tiles[8 - 1].GetComponent<BoxCollider2D>().enabled = false;
                tiles[8 - 1].transform.GetChild(0).gameObject.SetActive(true);

                tiles[12 - 1].SetActive(true);
                tiles[12 - 1].GetComponent<SpriteRenderer>().enabled = false;
                tiles[12 - 1].GetComponent<BoxCollider2D>().enabled = false;
                tiles[12 - 1].transform.GetChild(0).gameObject.SetActive(true);

                tiles[14 - 1].SetActive(true);
                tiles[14 - 1].GetComponent<SpriteRenderer>().enabled = false;
                tiles[14 - 1].GetComponent<BoxCollider2D>().enabled = false;
                tiles[14 - 1].transform.GetChild(0).gameObject.SetActive(true);

                //Remove 18                
                tiles[18 - 1].GetComponent<SpriteRenderer>().enabled = true;
                tiles[18 - 1].GetComponent<BoxCollider2D>().enabled = true;
                tiles[18 - 1].transform.GetChild(0).gameObject.SetActive(false);
                tiles[18 - 1].SetActive(false);
                break;
            case 4:
                tiles[8 - 1].SetActive(true);
                tiles[8 - 1].GetComponent<SpriteRenderer>().enabled = false;
                tiles[8 - 1].GetComponent<BoxCollider2D>().enabled = false;
                tiles[8 - 1].transform.GetChild(0).gameObject.SetActive(true);

                tiles[12 - 1].SetActive(true);
                tiles[12 - 1].GetComponent<SpriteRenderer>().enabled = false;
                tiles[12 - 1].GetComponent<BoxCollider2D>().enabled = false;
                tiles[12 - 1].transform.GetChild(0).gameObject.SetActive(true);

                tiles[14 - 1].SetActive(true);
                tiles[14 - 1].GetComponent<SpriteRenderer>().enabled = false;
                tiles[14 - 1].GetComponent<BoxCollider2D>().enabled = false;
                tiles[14 - 1].transform.GetChild(0).gameObject.SetActive(true);

                tiles[18 - 1].SetActive(true);
                tiles[18 - 1].GetComponent<SpriteRenderer>().enabled = false;
                tiles[18 - 1].GetComponent<BoxCollider2D>().enabled = false;
                tiles[18 - 1].transform.GetChild(0).gameObject.SetActive(true);
                break;
            default:
                break;
        }
    }

    IEnumerator LevelUpInTime()
    {
        yield return new WaitForSeconds(0.3f);

        audioSource.clip = collapseShip;
        audioSource.Play();

        foreach (var go in tiles)
        {
            go.GetComponent<TileMovement>().MoveToShipCenter();
        }
    }

}
