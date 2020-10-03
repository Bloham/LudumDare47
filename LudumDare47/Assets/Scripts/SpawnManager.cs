using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public float spawnSeperation = 20f;
    public float spawnInterval = 1.5f;
    public float trashLifetime = 10f;
    
    public GameObject[] trashPrefabs;
    public GameObject[] spawnPoints;
    public int spawnPointIndex;
    public int trashIndex;



    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnTrash", 1, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            SpawnTrash();
        }
    }
    public void SpawnTrash()
    {
        int trashIndex = Random.Range(0, trashPrefabs.Length);
        int spawnPointIndex = Random.Range(0, spawnPoints.Length);
        Instantiate(trashPrefabs[trashIndex], spawnPoints[spawnPointIndex].transform.position, Random.rotation); //trashPrefabs[trashIndex].transform.rotation);

    }
}
