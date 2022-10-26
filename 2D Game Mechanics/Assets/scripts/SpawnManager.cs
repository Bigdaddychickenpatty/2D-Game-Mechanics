using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject EnemyPrefab;
    public float xRange = 7;
    public float yRange = 2.75f;

    // Start is called before the first frame update
    void Start()
    {
        float spawnPosX = Random.Range(-xRange, xRange);
        float spawnPosY = Random.Range(-yRange, yRange);

        Instantiate(EnemyPrefab, new Vector2(spawnPosX, spawnPosY), EnemyPrefab.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
