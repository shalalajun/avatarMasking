using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class maskAdd : MonoBehaviour
{
    public GameObject a;
    public GameObject b;

    void Start()
    {
        Mesh meshA = a.GetComponent<MeshFilter>().mesh;
        Mesh meshB = b.GetComponent<MeshFilter>().mesh;
        Color[] colorsA = meshA.colors;
        Color[] colorsB = meshB.colors;

        for (int i = 0; i < colorsA.Length; i++) {
            colorsA[i] = new Color(1.0f - colorsA[i].r, 1.0f - colorsA[i].g, 1.0f - colorsA[i].b);
            colorsB[i] -= colorsA[i];
        }
        meshB.colors = colorsB;
    }
}
