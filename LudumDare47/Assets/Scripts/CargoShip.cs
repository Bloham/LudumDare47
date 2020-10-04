using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CargoShip : MonoBehaviour
{
    public float speed;
    public float destroyDistance = -250f;

    public GameObject cargoShipPrefab;
    public GameObject cargoShipSpawn;

    // Start is called before the first frame update
    void Start()
    {
            
            
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += -transform.right * speed * Time.deltaTime;
        if(transform.position.x < destroyDistance)
        {
            Instantiate(cargoShipPrefab, cargoShipSpawn.transform.position, Quaternion.Euler(-90,0,0));
            Destroy(gameObject);
        }
    }
}
