using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusPointsSpawner : MonoBehaviour
{
    public GameObject SpawnedPrefab;
    public int DistanceMin = 5;
    public int DistanceMax = 6;
    public float GroundY = 4.5f;

    public float SpawnTimeMin = 5f;
    public float SpawnTimeMax = 8f;
    private void Start()
    {
        StartCoroutine(BonusSpawner(Random.Range(SpawnTimeMin, SpawnTimeMax), SpawnedPrefab));
    }

    private IEnumerator BonusSpawner(float randomtime, GameObject Bonus)
    {
        yield return new WaitForSeconds(randomtime);
        Instantiate(Bonus, new Vector3(Random.Range(DistanceMin, DistanceMax), GroundY, 0), Quaternion.identity);
        StartCoroutine(BonusSpawner(randomtime, Bonus));
    }
}
