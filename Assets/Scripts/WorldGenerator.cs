using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldGenerator : MonoBehaviour
{
    public GameObject player;

    public int sizeX;
    public int sizeZ;

    public int groundHeight;
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
        for (int x = 0; x < sizeX; x++)
        {
            for (int z = 0; z < sizeZ; z++)
            {
                int maxY = (int)(Mathf.PerlinNoise((x / 2 + seed) / terDetail, (z / 2 + seed) / terDetail) * terHeight);
                maxY += groundHeight;

                GameObject grass = Instantiate(blocks[0], new Vector3(x, maxY, z), Quaternion.identity) as GameObject;
                grass.transform.SetParent(GameObject.FindGameObjectWithTag("Environment").transform);

                for(int y = 0; y < maxY; y++)
                {
                    int dirtLayers = Random.Range(1, 5);
                    if(y >= maxY - dirtLayers) 
                    {
                        GameObject dirt = Instantiate(blocks[2], new Vector3(x, y, z), Quaternion.identity) as GameObject;
                        dirt.transform.SetParent(GameObject.FindGameObjectWithTag("Environment").transform);
                    } else 
                    {
                        GameObject stone = Instantiate(blocks[1], new Vector3(x, y, z), Quaternion.identity) as GameObject;
                        stone.transform.SetParent(GameObject.FindGameObjectWithTag("Environment").transform);
                    }
                }

                if(x == (int)(sizeX / 2) && z == (int)(sizeZ / 2))
                {
                    Instantiate(player, new Vector3(x, maxY + 3, z), Quaternion.identity);
                }
            }
        }
    }
}