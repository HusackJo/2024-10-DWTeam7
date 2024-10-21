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
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
