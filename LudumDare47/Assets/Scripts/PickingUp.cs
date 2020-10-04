using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickingUp : MonoBehaviour
{
    // AKA INVENTORY
    public int redTrash;
    public Color32 redPort = new Color32(255, 55, 0, 255);
    public int blueTrash;
    public Color bluePort = Color.white;
    public int trashUtilization;
    public float addFuel = 6f;

    public GameObject[] cargo;
    private int cargoIndex;

    private Score score;
    private Timer fuel;

    // Start is called before the first frame update
    void Start()
    {
        cargoIndex = cargo.Length;
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
            foreach (GameObject box in cargo)
            {
                if (box.GetComponent<Image>().color == bluePort)
                {
                    box.SetActive(false);
                    trashUtilization -= 1;
                }
            }
            blueTrash = 0;
            score.scoreText.text = "" + score.score;
            fuel.fuel += addFuel;
            Debug.Log("Score: " + score.score);

        }
        if (other.gameObject.CompareTag("RightPort"))
        {
            score.score += redTrash;
            foreach (GameObject box in cargo)
            {
                if (box.GetComponent<Image>().color == redPort)
                {
                    box.SetActive(false);
                    trashUtilization -= 1;
                }
            }
            redTrash = 0;
            score.scoreText.text = "" + score.score;
            fuel.fuel += addFuel;
            Debug.Log("Score: " + score.score);

        }

        if (other.gameObject.CompareTag("LeftTrash"))
        {
            if (trashUtilization < cargoIndex)
            {
                GameObject cargoDisplay = cargo[trashUtilization];
                var image = cargoDisplay.GetComponent<Image>();
                trashUtilization += 1;
                cargoDisplay.SetActive(true);
                image.color = bluePort;
                blueTrash += 1;
                Destroy(other.gameObject);
            }
            else
            {
                Destroy(other.gameObject);
            }
        }
        if (other.gameObject.CompareTag("RightTrash"))
        {
            if (trashUtilization < cargoIndex)
            {
                GameObject cargoDisplay = cargo[trashUtilization];
                var image = cargoDisplay.GetComponent<Image>();
                trashUtilization += 1;
                cargoDisplay.SetActive(true);
                image.color = redPort;
                redTrash += 1;
                Destroy(other.gameObject);
            }
            else
            {
                Destroy(other.gameObject);
            }
        }
    }
}
