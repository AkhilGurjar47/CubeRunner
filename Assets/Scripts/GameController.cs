using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameController : MonoBehaviour
{
    public GameObject gameOverPanel;
    public GameObject TapToStart;
    public GameObject bulletText;
    private void Start()
    {
        gameOverPanel.SetActive(false);
        PauseGame();
        TapToStart.SetActive(true);
        bulletText.SetActive(false);
    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            StartGame();
        }
    }
    public void GameOver()
    { 
        gameOverPanel.SetActive(true);
        bulletText.SetActive(false);
    }
    public void Restart()
    {
        bulletText.SetActive(false);
        SceneManager.LoadScene("Game");
    }
    public void QuitGame()
    { 
        Application.Quit();
    }
    public void PauseGame()
    {
        Time.timeScale = 0f;
    }
    public void StartGame()
    {
        Time.timeScale = 1f;
        TapToStart.SetActive(false);
        bulletText.SetActive(true);
    }
}
