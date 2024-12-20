using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// Controls inputs and calls functions to move legs
/// </summary>
public class CharacterController : MonoBehaviour
{
    [SerializeField]
    public float legForceX, legForceY, kneeForceX, kneeForceY;
    public Rigidbody2D knee1RB, knee2RB;
    public Foot leg1, leg2;
    public float legsCoolDown;
    public bool hasKnees;
    public FloorScroller FloorManager;

    [HideInInspector]
    public AudioManager audioMan;
    public float groundSpeed;
    private float leg1CoolTimer, leg2CoolTimer;

    private void Awake()
    {
        leg1CoolTimer = legsCoolDown;
        leg2CoolTimer = legsCoolDown;
        groundSpeed = FloorManager.moveSpeed + (float)-0.2;
        audioMan = GameObject.Find("AudioManager").GetComponent<AudioManager>();
        Debug.Log($"{audioMan.name}");
    }

    private void Update()
    {
        HandleMovement();
    }

    /// <summary>
    /// handles cooldown for each foot, checks for input, and adds forces
    /// </summary>
    private void HandleMovement()
    {
                        //Leg Moves
        //Cooldowns, just so you can't double jump too hard
        if (leg1.isGrounded)
        {
            leg1CoolTimer = legsCoolDown;
        }
        if (leg2.isGrounded)
        {
            leg2CoolTimer = legsCoolDown;
        }
        //handle input & add forces
        if (Input.GetKeyDown(KeyCode.S))
        {
            if (leg1CoolTimer >= legsCoolDown)
            {
                leg1.rigidBody.AddForce(new Vector2(legForceX, legForceY));
                leg1CoolTimer = 0;
                audioMan.PlaySFX("Move Sound");
                //Debug.Log("Added Force");
            }
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            if (leg2CoolTimer >= legsCoolDown)
            {
                leg2.rigidBody.AddForce(new Vector2(legForceX, legForceY));
                leg2CoolTimer = 0;
                audioMan.PlaySFX("Move Sound");
                //Debug.Log("Added Force");
            }
        }

        //Knee moves, input and forces
        if (hasKnees)
        {
            if (Input.GetKeyDown(KeyCode.A) && leg1CoolTimer >= legsCoolDown)
            {
                knee1RB.AddForce(new Vector2(kneeForceX, kneeForceY));
                leg1CoolTimer = 0;
                audioMan.PlaySFX("Move Sound");
            }
            if (Input.GetKeyDown(KeyCode.W) && leg2CoolTimer >= legsCoolDown)
            {
                knee2RB.AddForce(new Vector2(kneeForceX, kneeForceY));
                leg2CoolTimer = 0;
                audioMan.PlaySFX("Move Sound");
            }
        }
        groundSpeed -= (float)0.00002;
    }
}
