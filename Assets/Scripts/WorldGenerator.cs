using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldGenerator : MonoBehaviour
{
    public int sideX;
    public int sideZ;

    public GameObject[] blocks;

    void Start()
    {
        Generate();
    }

    void Generate()
    {
        for(int x = 0; x < sideX; x++)
        {
            for (int z = 0; z < sideZ; z++)
            {
                Instantiate(blocks[0], new Vector3(x, 0, z), Quaternion.identity);
            }
        }
    }
}
