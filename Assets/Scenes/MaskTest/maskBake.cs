using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class maskBake : MonoBehaviour
{
    public SkinnedMeshRenderer a;
    public SkinnedMeshRenderer b;

    void Start()
    {
       Mesh meshA = a.sharedMesh;
       Mesh meshB = Instantiate(b.sharedMesh); // Create a new mesh to avoid modifying the original one

        Color[] colorsA = meshA.colors;
        Color[] colorsB = meshB.colors;


      if (colorsA.Length != colorsB.Length)
        {
            Debug.LogError("Meshes A and B have a different number of vertices. The script cannot be executed.");
            return;
        }

        for (int i = 0; i < colorsA.Length; i++)
        {
            colorsA[i] = new Color(1.0f - colorsA[i].r, 1.0f - colorsA[i].g, 1.0f - colorsA[i].b);
            colorsB[i] -= colorsA[i];
        }

        meshB.colors = colorsB;
        b.sharedMesh = meshB; // Assign the modified mesh to the Skinned Mesh Renderer
    }
}
