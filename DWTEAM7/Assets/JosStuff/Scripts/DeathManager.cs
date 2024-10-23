using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Attach to head component, runs function from GM to kill player on collision
/// </summary>
public class DeathManager : MonoBehaviour
{
    private GameManager GM;
    private void Awake()
    {
        GM = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == (6))
        { 
            Debug.Log("Player head touched ground!");
            //if player is alive
            GM.KillPlayer();
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            Debug.Log("Player head touched The enemy!!");
            //if player is alive
            GM.KillPlayer();
        }
    }
}
