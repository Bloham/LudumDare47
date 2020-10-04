using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickingUp : MonoBehaviour
{
    // AKA INVENTORY
    public int blueTrash;
    public float addFuel = 6f;
    public int maxChargo = 6;

    public GameObject chargo1;
    public GameObject chargo2;
    public GameObject chargo3;
    public GameObject chargo4;
    public GameObject chargo5;
    public GameObject chargo6;


    private Score score;
    private Timer fuel;

    // Start is called before the first frame update
    void Start()
    {
        score = FindObjectOfType<Score>();
        fuel = FindObjectOfType<Timer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("LeftPort"))
        {
            score.score += blueTrash;
            ChangeCargo(0);
            score.scoreText.text = "" + score.score;
            fuel.fuel += addFuel * blueTrash;
            blueTrash = 0;
            Debug.Log("Score: " + score.score);

        }

        if (other.gameObject.CompareTag("LeftTrash") && blueTrash <= maxChargo)
        { 
                blueTrash += 1;
                ChangeCargo(blueTrash);
                Destroy(other.gameObject);
        }
    }
    private void ChangeCargo(int chargo)
    {
        if (chargo == 0)
        {
            chargo1.SetActive(false);
            chargo2.SetActive(false);
            chargo3.SetActive(false);
            chargo4.SetActive(false);
            chargo5.SetActive(false);
            chargo6.SetActive(false);
        }
        if (chargo == 1)
        {
            chargo1.SetActive(true);
            chargo2.SetActive(false);
            chargo3.SetActive(false);
            chargo4.SetActive(false);
            chargo5.SetActive(false);
            chargo6.SetActive(false);
        }
        if (chargo == 2)
        {
            chargo1.SetActive(true);
            chargo2.SetActive(true);
            chargo3.SetActive(false);
            chargo4.SetActive(false);
            chargo5.SetActive(false);
            chargo6.SetActive(false);
        }
        if (chargo == 3)
        {
            chargo1.SetActive(true);
            chargo2.SetActive(true);
            chargo3.SetActive(true);
            chargo4.SetActive(false);
            chargo5.SetActive(false);
            chargo6.SetActive(false);
        }
        if (chargo == 4)
        {
            chargo1.SetActive(true);
            chargo2.SetActive(true);
            chargo3.SetActive(true);
            chargo4.SetActive(true);
            chargo5.SetActive(false);
            chargo6.SetActive(false);
        }
        if (chargo == 5)
        {
            chargo1.SetActive(true);
            chargo2.SetActive(true);
            chargo3.SetActive(true);
            chargo4.SetActive(true);
            chargo5.SetActive(true);
            chargo6.SetActive(true);
        }
        if (chargo == 6)
        {
            chargo1.SetActive(true);
            chargo2.SetActive(true);
            chargo3.SetActive(true);
            chargo4.SetActive(true);
            chargo5.SetActive(true);
            chargo6.SetActive(true);
        }
    }
}
