using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    private Transform vertexTransform1;

    [SerializeField]
    private Transform vertexTransform2;

    [SerializeField]
    private Transform vertexTransform3;

    [SerializeField]
    private GameObject sphere;

    void Start()
    {
        Vector3 spawnPosition = vertexTransform3.position + (Vector3)( Random.insideUnitCircle * 1 );
        Instantiate(
            sphere,
            spawnPosition,
            Quaternion.identity
        );
    }
}
