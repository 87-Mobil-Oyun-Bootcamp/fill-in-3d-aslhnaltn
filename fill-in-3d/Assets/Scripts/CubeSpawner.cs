using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{ 
    private Vector3 pos;
    public GameObject firstCube;

    Vector3 blockPos = Vector3.zero;
    public Sprite sprite;
    public GameObject cube;


    private void Start()
    {
        CubeSpawn();
    }

    void CubeSpawn()
    {
        int cubeCounter = 0;
        int cubeAmount = 0;

        for (int x = 0; x < 8; x++)
        {
            for (int y = 0; y < 2; y++)
            {
                for (int z = 0; z < 2; z++)
                {
                    GameObject cube = Instantiate(firstCube, transform);

                    cube.transform.localPosition = new Vector3(x-3, y, z);

                    cubeCounter++;

                    if (cubeCounter == cubeAmount)
                    {
                        return;
                    }

                }
            }
        }
    }
}