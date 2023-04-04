using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class maskAddSkineed02 : MonoBehaviour
{
    public SkinnedMeshRenderer a;
    public SkinnedMeshRenderer b;

    void Start()
    {
        Mesh meshA = new Mesh();
        Mesh meshB = new Mesh();

        a.BakeMesh(meshA);
        b.BakeMesh(meshB);

        Color[] colorsA = meshA.colors;
        Color[] colorsB = meshB.colors;

        for (int i = 0; i < colorsA.Length; i++)
        {
            colorsA[i] = new Color(1.0f - colorsA[i].r, 1.0f - colorsA[i].g, 1.0f - colorsA[i].b);
            colorsB[i] -= colorsA[i];
        }

        meshB.colors = colorsB;
        b.sharedMesh.colors = colorsB;
    }
}
