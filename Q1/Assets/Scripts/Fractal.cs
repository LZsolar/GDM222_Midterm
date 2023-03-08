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

    List<GameObject> cube = new List<GameObject>();

    void Start()
    {
        //  This statement create a game object given a prefab, position and rotation.
        GameObject newObject = Instantiate(
            //  This parameter sets a prefab for an instance to be created.
            cubePrefab,

            //  This parameter sets an instance position to (0, 0, 0).
            Vector3.zero,

            //  This parameter sets an instance rotation to (0, 0, 0).
            Quaternion.identity
        );
        cube.Add(newObject);
    }
    void addVeryFirst()
    {
        GameObject copy = Instantiate(cubePrefab, Vector3.zero, Quaternion.identity);
        copy.transform.localScale = new Vector3(size, size, size);
        cube.Add(copy);
    }
    public void addFirst()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Player");
        foreach (GameObject enemy in enemies)
            GameObject.Destroy(enemy);

        cube.Clear();
        addVeryFirst();

        for (int i = 1; i < iteration; i++)
        {
            List<GameObject> newCube = Split(cube);
            foreach (var obj in cube)
            {
                Destroy(obj);
            }
            cube = newCube;
        }
    }


    List<GameObject> Split(List<GameObject> cube)
    {
        List<GameObject> subCube = new List<GameObject>();

        foreach (var obj in cube)
        {
            for (int x = -1; x < 2; x++)
            {
                for (int y = -1; y < 2; y++)
                {
                    for (int z = -1; z < 2; z++)
                    {
                        float xx = x * (size);
                        float yy = y * (size);
                        float zz = z * (size);
                        int sum = Mathf.Abs(x)+ Mathf.Abs(y)+ Mathf.Abs(z);
                        if (sum>1)
                        {
                            Vector3 CubePos = new Vector3(xx, yy, zz) + obj.transform.position;

                            GameObject copy = Instantiate(obj, CubePos, Quaternion.identity);
                            copy.transform.localScale = new Vector3(size, size, size);
                            subCube.Add(copy);
                        }
                    }
                }
            }
        }
        return subCube;

    }

}



