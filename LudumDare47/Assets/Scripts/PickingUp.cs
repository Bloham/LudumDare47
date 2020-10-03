using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickingUp : MonoBehaviour
{
    private Inventory inventory;
    // Start is called before the first frame update
    void Start()
    {
        inventory = GetComponent<Inventory>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("LeftTrash"))
        {
            inventory.leftHabourTrash += 1;
            Debug.Log("Left Harbour Trash: " + inventory.leftHabourTrash + "Right Harbour Trash " + inventory.rightHarbourTrash);
            Destroy(other.gameObject);
        }
        if (other.gameObject.CompareTag("RightTrash"))
        {
            inventory.rightHarbourTrash += 1;
            Debug.Log("Left Harbour Trash: " + inventory.leftHabourTrash + "Right Harbour Trash " + inventory.rightHarbourTrash);
            Destroy(other.gameObject);
        }
    }
}
