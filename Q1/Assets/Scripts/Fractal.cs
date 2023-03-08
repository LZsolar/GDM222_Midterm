using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fractal : MonoBehaviour
{
    [SerializeField]
    private GameObject cubePrefab;

    [SerializeField]
    private int iteration;

    [SerializeField]
    private float size;

    void Start()
    {
        //  This statement create a game object given a prefab, position and rotation.
        Instantiate(
            //  This parameter sets a prefab for an instance to be created.
            cubePrefab,

            //  This parameter sets an instance position to (0, 0, 0).
            Vector3.zero,

            //  This parameter sets an instance rotation to (0, 0, 0).
            Quaternion.identity
        );
    }
}
