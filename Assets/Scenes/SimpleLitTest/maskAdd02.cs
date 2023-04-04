using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class maskAdd02 : MonoBehaviour
{
   public GameObject a;
   public GameObject b;
   public GameObject c;

    void Start()
    {
        Mesh meshA = a.GetComponent<MeshFilter>().mesh;
        Mesh meshB = b.GetComponent<MeshFilter>().mesh;
        Mesh meshC = c.GetComponent<MeshFilter>().mesh;

        Color[] colorsA = meshA.colors;
        Color[] colorsB = meshB.colors;
        Color[] colorsC = meshC.colors;

        for (int i = 0; i < colorsA.Length; i++) {
            colorsA[i] = new Color(1.0f - colorsA[i].r, 1.0f - colorsA[i].g, 1.0f - colorsA[i].b);
            colorsB[i] -= colorsA[i];
        }
        meshB.colors = colorsB;

        for (int i = 0; i < colorsB.Length; i++) {
            colorsB[i] = new Color(1.0f - colorsB[i].r, 1.0f - colorsB[i].g, 1.0f - colorsB[i].b);
            colorsC[i] -= colorsB[i];
        }
        meshC.colors = colorsC;

    }
}
