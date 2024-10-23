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
    public bool hasKnees, hasKnob;
    public float powerAdjustment;
    public FloorScroller FloorManager;

    [HideInInspector]
    public float groundSpeed;
    private float leg1CoolTimer, leg2CoolTimer;
    private float legPower = 1;

    private void Awake()
    {
        leg1CoolTimer = legsCoolDown;
        leg2CoolTimer = legsCoolDown;
        groundSpeed = FloorManager.moveSpeed;
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
        else { leg1CoolTimer += Time.deltaTime; }
        if (leg2.isGrounded)
        {
            leg2CoolTimer = legsCoolDown;
        }
        else { leg2CoolTimer += Time.deltaTime; }
        //handle input & add forces
        if (Input.GetKeyDown(KeyCode.S))
        {
            if (leg1CoolTimer >= legsCoolDown)
            {
                leg1.rigidBody.AddForce(new Vector2(legForceX * legPower, legForceY * legPower));
                leg1CoolTimer = 0;
                //Debug.Log("Added Force");
            }
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            if (leg2CoolTimer >= legsCoolDown)
            {
                leg2.rigidBody.AddForce(new Vector2(legForceX *legPower, legForceY * legPower));
                leg2CoolTimer = 0;
                //Debug.Log("Added Force");
            }
        }

        //Knee moves, input and forces
        if (hasKnees)
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                knee1RB.AddForce(new Vector2(kneeForceX * legPower, kneeForceY * legPower));
            }
            if (Input.GetKeyDown(KeyCode.W))
            {
                knee2RB.AddForce(new Vector2(kneeForceX * legPower, kneeForceY * legPower));
            }
        }

        if (hasKnob)
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                legPower += powerAdjustment;
            }
            if (Input.GetKeyDown(KeyCode.E))
            {
                legPower -= powerAdjustment;
            }
        }
    }
}
