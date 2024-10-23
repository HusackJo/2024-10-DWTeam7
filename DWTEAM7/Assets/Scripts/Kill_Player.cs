using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Kill_Player : MonoBehaviour
{
    private GameManager GM;
    private void Awake()
    {
        GM = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GM.KillPlayer();
        } 

        if (collision.gameObject.CompareTag("Leg"))
        {
            GM.KillPlayer();
        }

    }
}
