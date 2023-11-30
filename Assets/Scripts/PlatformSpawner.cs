using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{
    [SerializeField] private GameObject platformPrefab;

    private Vector3 newSpawnPoint;

    private void Start()
    {
        newSpawnPoint = transform.position;
    }
    private void FixedUpdate()
    {
        newSpawnPoint.x += 1;
        newSpawnPoint.z += 1;
        Instantiate(platformPrefab, newSpawnPoint, Quaternion.identity);
    }


}
