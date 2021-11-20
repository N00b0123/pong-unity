using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool isPaused = false;
    public GameObject scoreUI;
    public GameObject pauseUI;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
                Resume();
            else
                Pause();
        }    
    }

    void Pause()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        Time.timeScale = 0f;
        scoreUI.SetActive(false);
        pauseUI.SetActive(true);
        isPaused = true;
    }

    public void Resume()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        Time.timeScale = 1f;
        pauseUI.SetActive(false);
        scoreUI.SetActive(true);
        isPaused = false;
    }

    public void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        isPaused = false;
        Time.timeScale = 1f;
        Cursor.visible = false;
    }

    public void NewGame()
    {
        Cursor.visible = false;
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
        Debug.Log("EXIT GAME");
        Application.Quit();
    }
}
