using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfRightingBody : MonoBehaviour
{
    public float stabPower, vertStabPower;
    public Transform foot1Pos, foot2Pos;
    private Rigidbody2D rB;

    private void Awake()
    {
        rB = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        float targetX = transform.position.x - ((foot1Pos.position.x + foot2Pos.position.x)/2);
        rB.AddForce(new Vector2(targetX * stabPower, 0)); 
        if (rB.velocityY < 0)
        {
            rB.AddForce(new Vector2(0, vertStabPower));
        }
    }
}
