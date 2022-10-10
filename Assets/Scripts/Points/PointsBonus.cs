using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointsBonus : MonoBehaviour
{
    public float BonusSpawnedTime = 0f;
    public float BonusDespawnTime = 5f;
    public float BonusSpeed = 3f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(BonusSpeed * (Time.deltaTime), 0, 0);
        BonusSpawnedTime += Time.deltaTime;
        if (BonusSpawnedTime >= BonusDespawnTime)
        {
            Destroy(this.gameObject);
        }

    }
}

