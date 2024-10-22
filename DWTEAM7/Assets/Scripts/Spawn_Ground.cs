using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Ground : MonoBehaviour
{
    public GameObject ground;

    public float spawnInterval;
    private float spawnTime;


    // Start is called before the first frame update
    void Start()
    {
        spawnTime = Time.time + spawnInterval;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= spawnTime)
        {
            SpawnGround();
            spawnTime = Time.time +spawnInterval;
        }
    }

    void SpawnGround()
    {
        GameObject newGround = Instantiate(ground);

        newGround.transform.position = new Vector2 (22, -4);

        newGround.name = "New Ground";
    }


}
