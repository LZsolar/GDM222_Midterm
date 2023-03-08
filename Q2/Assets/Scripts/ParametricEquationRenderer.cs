using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParametricEquationRenderer : MonoBehaviour
{
    [SerializeField]
    //  This component handles a line rendering given
    //  a set of positions (3D points).
    private LineRenderer lineRenderer;

    [SerializeField]
    private float a;

    [SerializeField]
    private float b;

    [SerializeField]
    private float c;

    [SerializeField]
    private float d;

    [SerializeField]
    private float minParameter;

    [SerializeField]
    private float maxParameter;

    [SerializeField]
    private int step;

    void Start()
    {
        Vector3[] points = new Vector3[4];
        points[0] = new Vector3(1, 1, 0);
        points[1] = new Vector3(-1, 1, 0);
        points[2] = new Vector3(-1, -1, 0);
        points[3] = new Vector3(1, -1, 0);

        //  Before setting a line renderer positions, the position
        //  count must be set first.
        lineRenderer.positionCount = 4;

        //  This statement sets a line renderer positions.
        //  Old positions are overridden.
        lineRenderer.SetPositions(points);
    }
}