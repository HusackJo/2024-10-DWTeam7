using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void BackToGame()
    {
        SceneManager.LoadScene("TestScene");
    }

    public void KillPlayer()
    {
        //Woohoo!
    }
}
