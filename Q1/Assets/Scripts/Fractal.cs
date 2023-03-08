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
    Vector3 position;

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

    public void size_generate()
    {
        GameObject[] Players = GameObject.FindGameObjectsWithTag("Player");
        foreach (GameObject Player in Players)
          GameObject.Destroy(Player);

        for (int x = 0; x < size; x++)
        {
            for(int y = 0; y < size; y++)
            {
                for(int z = 0; z < size; z++)
                {
                    float xx = x * 3f;
                    float yy = y * 3f;
                    float zz = z * 3f;

                    Vector3 CubePos = new Vector3(xx, yy, zz);
                    Instantiate(
                        //  This parameter sets a prefab for an instance to be created.
                        cubePrefab,

                        //  This parameter sets an instance position to (0, 0, 0).
                        CubePos,

                        //  This parameter sets an instance rotation to (0, 0, 0).
                        Quaternion.identity
                    );
                }
            }
        }
    }
}
