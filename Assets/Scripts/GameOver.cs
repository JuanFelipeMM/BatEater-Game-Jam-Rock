using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject gameOverMenu;
    public GameObject pauseMenu;
    public GameObject scoreUI;
    public GameObject sonsJogo;
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
            GameObject.FindWithTag("GameOver").GetComponent<Score>().scorePoint = scoreUI.GetComponent<Score>().scorePoint;
            scoreUI.GetComponent<Score>().textScore.text="";

        }
    }

    public void pauseGame()
    {
        sonsJogo.GetComponent<AudioSource>().volume = 0.2f;
        gameOverMenu.SetActive(true);
        Time.timeScale = 0;
        isGameOver = true;
    }

    public void resumeGame()
    {
        sonsJogo.GetComponent<AudioSource>().volume = 1f;
        gameOverMenu.SetActive(false);
        Time.timeScale = 1;
        isGameOver = false;
    }

    public void restart()
    {
        sonsJogo.GetComponent<AudioSource>().volume = 1f;
        Time.timeScale = 1;
        SceneManager.LoadScene("GamePlay");
    }
    public void backMenu()
    {

        Time.timeScale = 1;
        SceneManager.LoadScene("TelaTitulo");
    }
}
