using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KMeans : MonoBehaviour
{
    [SerializeField]
    private GameObject cube;

    [SerializeField]
    private int k;

    private List<GameObject> cubeList;
    private List<Renderer> cubeRendererList;

    //  This method sets a cube its color given its index
    //  in the cubeList and a new color.
    void SetCubeColor(int cubeIndex, Color color)
    {
        this.cubeRendererList[cubeIndex].material.SetColor("_Color", color);
    }

    void GenerateRandomCube()
    {
        this.cubeList = new List<GameObject>();
        this.cubeRendererList = new List<Renderer>();
        for(int i=0; i<100; i++)
        {
            for(int j=0; j<100; j++)
            {
                if( Mathf.PerlinNoise(0.05f*i, 0.05f*j) > Random.value )
                {
                    GameObject instance = Instantiate(
                        cube,
                        new Vector3(
                            i/10.0f,
                            0,
                            j/10.0f
                        ),
                        Quaternion.identity
                    );
                    this.cubeList.Add(instance);

                    Renderer renderer = instance.GetComponent<Renderer>();
                    this.cubeRendererList.Add(renderer);
                }
            }
        }
    }

    void ClusterCube()
    {
        for(int i=0; i<this.cubeList.Count; i++)
        {
            float hue = this.cubeList[i].transform.position.x/10.0f;
            this.SetCubeColor(
                i,

                //  This method returns an RGB color given
                //  HSV color components, hue, saturation and value.
                Color.HSVToRGB(
                    hue,
                    1,
                    1
                )
            );
        }
    }

    void Start()
    {
        this.GenerateRandomCube();
        this.ClusterCube();
    }
}
