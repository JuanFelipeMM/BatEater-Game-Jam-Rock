using System.Collections;
using System.Collections.Generic;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public GameObject pauseMenu;
    public GameObject sonsJogo;
    public static bool isPaused;
    void Start()
    {
        resumeGame();
        pauseMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) ||Input.GetButtonDown("Start"))
        {
            if (isPaused)
            {
                resumeGame();
            }
            else
            {
                pauseGame();
            }
        }
    }

    public void pauseGame()
    {
        sonsJogo.GetComponent<AudioSource>().volume = 0.2f;
        pauseMenu.SetActive(true);
        Time.timeScale = 0;
        isPaused = true;
    }

    public void resumeGame()
    {
        sonsJogo.GetComponent<AudioSource>().volume = 1f;
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
        isPaused = false;
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
