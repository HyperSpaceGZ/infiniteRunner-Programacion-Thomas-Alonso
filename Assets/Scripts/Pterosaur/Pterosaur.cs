using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pterosaur : MonoBehaviour
{
    public float PterosaurSpawnedTime = 0f;
    public float PterosaurDespawnTime = 5f;
    public float PterosaurSpeed = 3f;

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(PterosaurSpeed * (Time.deltaTime), 0, 0);
        PterosaurSpawnedTime += Time.deltaTime;
        if (PterosaurSpawnedTime >= PterosaurDespawnTime)
        {
            Destroy(this.gameObject);
        }

    }
}

