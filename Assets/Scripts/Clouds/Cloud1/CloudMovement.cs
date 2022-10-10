using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudMovement : MonoBehaviour
{
    public float CloudSpawnedTime = 0f;
    public float CloudDespawnTime = 5f;
    public float CloudSpeed = 3f;

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(CloudSpeed * (Time.deltaTime), 0, 0);
        CloudSpawnedTime += Time.deltaTime;
        if (CloudSpawnedTime >= CloudDespawnTime)
        {
            Destroy(this.gameObject);
        }

    }
}
