using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipNormals : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Mesh mesh = this.GetComponent<MeshFilter>().mesh;

        var normals = mesh.normals;
        for (int i = 0; i < normals.Length; i++)
        {
            normals[i] = -1 * normals[i];
        }
        mesh.normals = normals;

        for (int i = 0; i < mesh.subMeshCount; i++)
        {
            var tris = mesh.GetTriangles(i);
            for (int j = 0; j < tris.Length; j += 3)
            {
                var temp = tris[j];
                tris[j] = tris[j + 1];
                tris[j + 1] = temp;
            }

            mesh.SetTriangles(tris, i);
        }
        this.GetComponent<MeshFilter>().mesh = mesh;
        this.GetComponent<MeshCollider>().sharedMesh = mesh;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
