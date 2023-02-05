using System.Collections;
using UnityEngine;

public class SpawnObjects : MonoBehaviour
{

    public GameObject pickUps;
    public GameObject obstacles;
    public float waitTime;
    public Vector2 minSpawnPoistion;
    public Vector2 maxSpawnPoistion;

    void Start()
    {
        StartCoroutine(SpawnTimer());
    }

    public void SpawnPickUpTiles()
    {
        Vector2 spawnPoistion = new Vector2(Random.Range(minSpawnPoistion.x, maxSpawnPoistion.x), Random.Range(minSpawnPoistion.y, maxSpawnPoistion.y));
        Instantiate(pickUps, spawnPoistion, Quaternion.identity);
    }

    public void SpawnObstacles()
    {
        Vector2 spawnPoistion = new Vector2(Random.Range(minSpawnPoistion.x, maxSpawnPoistion.x), Random.Range(minSpawnPoistion.y, maxSpawnPoistion.y));
        Instantiate(obstacles, spawnPoistion, Quaternion.identity);
    }

    IEnumerator SpawnTimer()
    {
        while (true)
        {
            SpawnPickUpTiles();
            SpawnObstacles();
            yield return new WaitForSeconds(waitTime);
        }
    }

}
