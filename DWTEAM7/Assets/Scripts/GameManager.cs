using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //Load Scenes
    private AudioManager audioManager;

    private void Awake()
    {
        audioManager = GameObject.Find("AudioManager").GetComponent<AudioManager>();
    }
    private void Start()
    {
        if(SceneManager.GetActiveScene().name == "Main Game")
        {
            audioManager.PlaySFX("Vine Boom");
        }
        else if (SceneManager.GetActiveScene().name == "Game Over")
        {
            audioManager.PlaySFX("Scream");
        }
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("Main Game Dupe2");
    }

    public void KillPlayer()
    {
        SceneManager.LoadScene("Game Over");
    }

    public void Menu()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void QuitThisBitch()
    {
        Application.Quit();
        PlayerPrefs.DeleteAll();
    }
}
