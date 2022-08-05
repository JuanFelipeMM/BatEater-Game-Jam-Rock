using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject gameOverMenu;
    public GameObject pauseMenu;
    public static bool isGameOver;
    void Start()
    {
        resumeGame();
        gameOverMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (isGameOver)
        {
            pauseGame();
            pauseMenu.SetActive(false);
            
            GameObject.FindWithTag("GameOver").GetComponent<Score>().scorePoint = GameObject.FindWithTag("Score").GetComponent<Score>().scorePoint;
        }
    }

    public void pauseGame()
    {
        gameOverMenu.SetActive(true);
        Time.timeScale = 0;
        isGameOver = true;
    }

    public void resumeGame()
    {
        gameOverMenu.SetActive(false);
        Time.timeScale = 1;
        isGameOver = false;
    }

    public void restart()
    {
        SceneManager.LoadScene("GamePlay");
    }
    public void backMenu()
    {
        SceneManager.LoadScene("TelaTitulo");
    }
}
