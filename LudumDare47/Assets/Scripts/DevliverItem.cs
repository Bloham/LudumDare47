using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;


public class DevliverItem : MonoBehaviour
{
    private Inventory inventory;
    private Score score;
    // Start is called before the first frame update
    void Start()
    {
        inventory = GetComponent<Inventory>();
        score = FindObjectOfType<Score>();
        Debug.Log(score);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("LeftPort"))
        {
            score.score += inventory.leftHabourTrash;
            inventory.leftHabourTrash = 0;
            score.scoreText.text = "" + score.score;
            Debug.Log("Score: " + score.score);

        }
        if (other.gameObject.CompareTag("RightPort"))
        {
            score.score += inventory.rightHarbourTrash;
            inventory.rightHarbourTrash = 0;
            score.scoreText.text = "" + score.score;
            Debug.Log("Score: " + score.score);

        }
    }
}
