using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameController : MonoBehaviour
{
    public GameObject gameOverPanel;
    public GameObject TapToStart;
    public GameObject scoreText;
    public GameObject bulletText;
    public AudioSource audioSouceGameOver;

    private void Awake()
    {
        audioSouceGameOver = GetComponent<AudioSource>();
    }
    private void Start()
    {
        gameOverPanel.SetActive(false);
        PauseGame();
        TapToStart.SetActive(true);
        scoreText.SetActive(false);
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
        scoreText.SetActive(false);
        bulletText.SetActive(false);
        audioSouceGameOver.Play();
        Time.timeScale = 0f;
    }
    public void Restart()
    {
        scoreText.SetActive(false);
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
        scoreText.SetActive(true);
        bulletText.SetActive(true);
    }
}
