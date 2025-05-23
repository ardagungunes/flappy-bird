using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject pipePair;

    public float spawnInterval = 2.5f;

    float timer = 0f;
    float destroyTimer = 0f;
    GameObject clonedPipe;
    List<GameObject> pipes = new List<GameObject>();

    void Update()
    {
        timer += Time.deltaTime;
        destroyTimer += Time.deltaTime;

        if (timer >= spawnInterval)
        {
            
            clonedPipe = Instantiate(pipePair, new Vector3(4f, Random.Range(-2f, 2f), -1f), Quaternion.identity);
            timer = 0f;
            
        }

       
    }
}
