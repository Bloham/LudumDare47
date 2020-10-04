using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CanvasManager : MonoBehaviour
{
    public GameObject gameOverScreen;
    public GameObject tutorialScreen;
    public bool gameIsPaused;
    public bool gameOver;
    public float tutorialTime;
        // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
        StartCoroutine(Tutorial());
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            
            RestartGame();
        }
    }

    public void GameOver()
    {
        PauseGame();
        gameOverScreen.SetActive(true);
        gameOver = true;

    }

    void PauseGame()
    {
        gameIsPaused = !gameIsPaused;
        if (gameIsPaused)
        {
            Time.timeScale = 0f;
            Debug.Log("Timescale = " + Time.timeScale);
        }
        else
        {
            if(gameOver == false)
            {
                Time.timeScale = 1;
            }

        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    private IEnumerator Tutorial()
    {
        yield return new WaitForSeconds(tutorialTime);
        tutorialScreen.SetActive(false);
    }
}
