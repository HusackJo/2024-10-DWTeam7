using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_Ground : MonoBehaviour
{
    [SerializeField]
    private float scrollFactor = 2.0f;
    [SerializeField]
    private float scrollSpeed;
    [SerializeField]
    private float paralaxEffect;

    private SpriteRenderer sr;
    private float length;
    private float count;
    [SerializeField]
    private string objTag;

    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();

        length = sr.bounds.size.x;
        objTag = gameObject.tag;

        count = GameObject.FindGameObjectsWithTag(objTag).Length;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        scrollSpeed = scrollFactor * paralaxEffect;

        transform.Translate(Vector3.right * scrollSpeed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.transform.parent = transform;
        }

        if (collision.gameObject.CompareTag("Legs"))
        {
            collision.transform.parent = transform;
        }

        if (collision.gameObject.CompareTag("Destroy"))
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.transform.parent = null;
        }

        if (collision.gameObject.CompareTag("Legs"))
        {
            collision.transform.parent = null;
        }
    }
}
