using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float timeRemaining = 20f;
    public CanvasManager canvasManager;

    bool timeIsOver = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
        }
        else
        {
            if (timeIsOver == false)
            {
                TimeOver();
            }
            

        }
    }
    private void TimeOver()
    {
        timeIsOver = true;

        Debug.Log("Game Over");
        canvasManager.GameOver();
    }
}
