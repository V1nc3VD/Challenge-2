using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float startDelay = 2.0f;



    private void Update()
    {


    }

    // Start is called before the first frame update
    void Start()
    {
        Invoke("SpawnRandomBall",  startDelay);
    }

    // Spawn random balls
    void SpawnRandomBall ()
    {

        //zorgt ervoor dat de ballen op een random tijd spawnen
        float spawnInterval = Random.Range(3.0f, 5.0f);
        
        //random x position at top of play area
        int index = Random.Range(0, ballPrefabs.Length);
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[index], spawnPos, ballPrefabs[index].transform.rotation);
        Invoke("SpawnRandomBall",  spawnInterval);
    }
    
    
}
