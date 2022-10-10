using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CactusSpawner : MonoBehaviour
{
    public GameObject SpawnedPrefab;
    public int DistanceMin = 19;
    public int DistanceMax = 23;
    public float GroundY = 0.97f;

    public float SpawnTimeMin = 3f;
    public float SpawnTimeMax = 5f;

    private void Start()
    {
        StartCoroutine(ObstacleSpawner(Random.Range(SpawnTimeMin, SpawnTimeMax), SpawnedPrefab));
    }

    private IEnumerator ObstacleSpawner(float randomtime, GameObject Obstacle)
    {
        yield return new WaitForSeconds(randomtime);
        Instantiate(Obstacle, new Vector3(Random.Range(DistanceMin, DistanceMax), GroundY, 0), Quaternion.identity);
        StartCoroutine(ObstacleSpawner(randomtime, Obstacle));
    }
}