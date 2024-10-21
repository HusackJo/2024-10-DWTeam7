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
    void Update()
    {
        scrollSpeed = scrollFactor * paralaxEffect;

        transform.Translate(Vector3.right * scrollSpeed * Time.deltaTime);

        if (transform.position.x < -length)
        {
            Reposition();
        }
    }

    void Reposition()
    {
        Vector2 offset = new Vector2(length * count, 0);

        transform.position = (Vector2)transform.position + offset;
    }
}
