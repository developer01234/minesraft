using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldGenerator : MonoBehaviour
{
    public GameObject player;

    public int sizeX;
    public int sizeZ;

    public float terDetail;
    public float terHeight;
    int seed;

    public GameObject[] blocks;

    void Start()
    {
        seed = Random.Range(100000, 999999);
        GenerateTerrain();
    }

    void GenerateTerrain ()
    {
        for (int x = 0; x < sizeX; x++) {
            for (int z = 0; z < sizeZ; z++) {
                Instantiate(blocks[0], new Vector3(x, 0, z), Quaternion.identity);
            }
        }
    }
}