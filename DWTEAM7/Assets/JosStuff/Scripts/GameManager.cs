using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
   //Load Scenes
    
    public void PlayGame()
    {
        SceneManager.LoadScene("Main Game Dupe2");
    }



    public void KillPlayer()
    {
        SceneManager.LoadScene("Game Over");
    }
}
