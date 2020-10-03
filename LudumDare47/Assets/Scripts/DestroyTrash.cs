using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTrash : MonoBehaviour
{
    public SpawnManager spawnManager;
    private Rigidbody rb;

    private void OnEnable()
    {
        rb = GetComponent<Rigidbody>();
        spawnManager = FindObjectOfType<SpawnManager>();
        StartCoroutine(DestroyItem());
        rb.AddExplosionForce(Random.Range(0, 1) * spawnManager.spawnSeperation, Random.rotation.eulerAngles, 50f);
    }

    IEnumerator DestroyItem()
    {
        yield return new WaitForSeconds(spawnManager.trashLifetime);
        Destroy(gameObject);

    }
}

