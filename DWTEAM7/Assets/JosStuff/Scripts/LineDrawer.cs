using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineDrawer : MonoBehaviour
{
    private LineRenderer lR;
    public Transform object1, object2;
    private void Awake()
    {
        lR = GetComponent<LineRenderer>();
    }
    private void Update()
    {
        lR.SetPosition(0, object1.position);
        lR.SetPosition(1, object2.position);
    }
}
