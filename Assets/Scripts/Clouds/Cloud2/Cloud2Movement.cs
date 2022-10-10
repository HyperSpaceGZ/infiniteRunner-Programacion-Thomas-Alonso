using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloud2Movement : MonoBehaviour
{
    public float Cloud2SpawnedTime = 0f;
    public float Cloud2DespawnTime = 5f;
    public float Cloud2Speed = 3f;

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(Cloud2Speed * (Time.deltaTime), 0, 0);
        Cloud2SpawnedTime += Time.deltaTime;
        if (Cloud2SpawnedTime >= Cloud2DespawnTime)
        {
            Destroy(this.gameObject);
        }

    }
}
