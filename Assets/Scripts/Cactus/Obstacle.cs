using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public float CactusSpawnedTime = 0f;
    public float CactusDespawnTime = 5f;
    public float CactusSpeed = 3f;

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(CactusSpeed * (Time.deltaTime),0 ,0);
        CactusSpawnedTime += Time.deltaTime;
        if (CactusSpawnedTime >= CactusDespawnTime)
        {
            Destroy(this.gameObject);
        }

    }
}

