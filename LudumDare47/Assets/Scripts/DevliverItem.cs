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
            while(pickingUp.blueTrash > 0)
            {
                score.score += pickingUp.blueTrash;
                score.scoreText.text = "" + score.score;
                fuel.fuel += addFuel * pickingUp.blueTrash;
                pickingUp.blueTrash = 0;
                Debug.Log("Score: " + score.score);
            }


        }
    }
}
