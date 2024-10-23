using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Foot : MonoBehaviour
{
    public Rigidbody2D rigidBody;
    public bool isGrounded;
    CharacterController characterController;

    private void Awake()
    {
        characterController = GetComponentInParent<CharacterController>();
        rigidBody = GetComponent<Rigidbody2D>();
        //Debug.Log($"{rigidBody.name} accessed");
    }

    private void FixedUpdate()
    {
        if (isGrounded)
        {
            //while grounded, move feet
            transform.Translate(Vector3.right * characterController.groundSpeed);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log($"{collision.gameObject.name}");
        if (collision.gameObject.tag == "Leg")
        {
            Physics2D.IgnoreCollision(collision.collider, GetComponent<Collider2D>());
        }
        if (collision.gameObject.layer == LayerMask.NameToLayer("Ground"))
        {
            isGrounded = true;
            //Debug.Log("Grounded!");
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Ground"))
        {
            isGrounded = false;
            Debug.Log("Not Grounded!");
        }
    }
}
