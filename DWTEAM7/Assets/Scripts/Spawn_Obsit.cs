using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Obsit : MonoBehaviour
{

    public GameObject spawnPrefab;

    public float spawnInt;
    private float spawnTime;
    // Start is called before the first frame update
    void Start()
    {
        spawnTime = Time.time + spawnInt;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= spawnTime)
        {
            SpawnObject();
            spawnTime = Time.time + spawnInt;
        }
    }

    void SpawnObject()
    {
        GameObject newObject = Instantiate(spawnPrefab);
        newObject.transform.position = new Vector2 (8,-2);
        newObject.name = "New Thing";
    }
}
