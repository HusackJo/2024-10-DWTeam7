using System.Collections;
using System.Collections.Generic;
using Unity.Hierarchy;
using UnityEngine;
/// <summary>
/// Manager for ground movement. spawns ground objects that scroll themselves based on this class' moveSpeed
/// </summary>
public class FloorScroller : MonoBehaviour
{
    [SerializeField] public GameObject groundPrefab, backgroundPrefab;
    [SerializeField] public Transform spawnPoint;
    [SerializeField] public float moveSpeed;
    [SerializeField] public float spawnInterval, bgSpawnInterval, bGSpawnDiff;
    [SerializeField] public float deadZone;

    private float spawnTimer;
    private int count;

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
            Instantiate(groundPrefab, spawnPoint.position, new Quaternion(0, 0, 0, 0), transform);
            if (count % bgSpawnInterval == 0)
            {
                Instantiate(backgroundPrefab, new Vector3(spawnPoint.position.x + bGSpawnDiff, spawnPoint.position.y + 4, spawnPoint.position.z), new Quaternion(0, 0, 0, 0), transform);
            }
            count++;
        }
    }
}
