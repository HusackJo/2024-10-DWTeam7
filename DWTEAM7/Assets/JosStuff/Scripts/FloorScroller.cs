using System.Collections;
using System.Collections.Generic;
using Unity.Hierarchy;
using UnityEngine;
/// <summary>
/// Manager for ground movement. spawns ground objects that scroll themselves based on this class' moveSpeed
/// </summary>
public class FloorScroller : MonoBehaviour
{
    [SerializeField] public GameObject groundPrefab;
    [SerializeField] public Transform spawnPoint;
    [SerializeField] public float moveSpeed;
    [SerializeField] public float spawnInterval;
    [SerializeField] public float deadZone;

    private float spawnTimer;

    private void Start()
    {
        Instantiate(groundPrefab, spawnPoint.position, new Quaternion(0, 0, 0, 0), transform);
    }
    void FixedUpdate()
    {
        spawnTimer += Time.deltaTime;
        if (spawnTimer >= spawnInterval)
        {
            spawnTimer -= spawnInterval;
            Instantiate(groundPrefab, spawnPoint.position, new Quaternion(0,0,0,0),transform);
        }
    }
}
