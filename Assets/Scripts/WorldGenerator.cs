using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldGenerator : MonoBehaviour
{
    public int sideX;
    public int sideZ;

    public float terDetail;
    public float terHeight;
    int seed;

    public GameObject[] blocks;

    void Start()
    {
        seed = Random.Range(100000, 999999);
        Generate();
    }

    void Generate()
    {
        for(int x = 0; x < sideX; x++)
        {
            for (int z = 0; z < sideZ; z++)
            {
                int y = (int)(Mathf.PerlinNoise((x / 2 + seed) / terDetail, (z / 2 + seed) / terDetail) * terHeight);
                GameObject Grass = Instantiate(blocks[0], new Vector3(x, y, z), Quaternion.identity) as GameObject;
                Grass.transform.SetParent(GameObject.FindGameObjectWithTag("Environment").transform);
            }
        }
    }
}
