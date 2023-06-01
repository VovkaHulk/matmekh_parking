using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    bool PauseGame = false;
    public GameObject Menu;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!PauseGame) StartPause();
            else Resume();
        }
    }

    public void Resume()
    {
        Menu.SetActive(false);
        Time.timeScale = 1f;
        PauseGame = false;
    }

    public void StartPause()
    {
        Menu.SetActive(true);
        Time.timeScale = 0f;
        PauseGame = true;
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
