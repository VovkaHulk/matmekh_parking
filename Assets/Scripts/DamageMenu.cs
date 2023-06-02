using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class DamageMenu : MonoBehaviour
{
    public GameObject damageMenu;
    // Start is called before the first frame update
    void Start()
    {
        damageMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RestartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void LoadMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
