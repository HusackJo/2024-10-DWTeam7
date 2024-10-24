using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// This class attaches to the ground and moves the ground based on the manager's set move speed.
/// </summary>
public class Ground : MonoBehaviour
{
    private FloorScroller floorScroller;
    private void Awake()
    {
        floorScroller = GetComponentInParent<FloorScroller>();
    }
    private void FixedUpdate()
    {
        transform.Translate(Vector3.right * floorScroller.moveSpeed); 
        if (transform.position.x < floorScroller.deadZone)
        {
            Destroy(gameObject);
        }
    }
}
