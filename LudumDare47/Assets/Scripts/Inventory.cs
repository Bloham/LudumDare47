using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public int redTrash;
    public int blueTrash;
    public int trashFull;

    public GameObject[] cargo;
    private int cargoIndex;
    

    private void Start()
    {
        cargoIndex = cargo.Length;
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadCargoToShip(string name, int trash)
    {
        trashFull += trash;
        if(trashFull <= cargoIndex)
        {
            if (name == "red")
            {
                redTrash += trash;
            }
            if (name == "blue")
            {
                blueTrash += trash;
            }
        }

        
    }
}
