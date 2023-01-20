using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallSpawner : MonoBehaviour
{
    public GameObject[] walls;
    public Vector2 positionRange = Vector2.one;
    public float minSpawnTime = 1.0f;
    public float maxSpawnTime = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("SpawnWall", Random.Range(minSpawnTime, maxSpawnTime));
    }

    void SpawnWall()
    {

        Invoke("SpawnWall", Random.Range(minSpawnTime, maxSpawnTime));
    }
}


