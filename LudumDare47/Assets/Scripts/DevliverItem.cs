using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;


public class DevliverItem : MonoBehaviour
{
    public float addFuel = 2f;

    private PickingUp pickingUp;
    private Score score;
    private Timer fuel;
    // Start is called before the first frame update
    void Start()
    {
        pickingUp = GetComponent<PickingUp>();
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
            score.score += pickingUp.blueTrash;
            pickingUp.blueTrash = 0;
            score.scoreText.text = "" + score.score;
            fuel.fuel += addFuel;
            Debug.Log("Score: " + score.score);

        }
        if (other.gameObject.CompareTag("RightPort"))
        {
            score.score += pickingUp.redTrash;
            pickingUp.redTrash = 0;
            score.scoreText.text = "" + score.score;
            fuel.fuel += addFuel;
            Debug.Log("Score: " + score.score);

        }
    }
}
