using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PixelCompleted : MonoBehaviour
{

    public GameObject cube;
    public Sprite imageSprite;
    Vector3 blockPos = Vector3.zero;
    int cubeCounter = 0;

    void Awake()
    {
        int size = 0;

        for (int x = 0; x < imageSprite.texture.width; x++)
        {
            for (int y = 0; y < imageSprite.texture.height; y++)
            {
                Color color = imageSprite.texture.GetPixel(x, y);

                if (color.a == 0)
                {
                    continue;
                }

                blockPos = new Vector3((x - (imageSprite.texture.width * .5f)), .5f, (y - (imageSprite.texture.height * .5f)));

                GameObject cubeObj = Instantiate(cube, transform);

                cubeObj.transform.localPosition = blockPos;

                cubeObj.GetComponent<Renderer>().material.color = color;

                cubeObj.transform.localScale = Vector3.one;

                size++;
            }
        }
        
        cubeCounter = size;
    }
}
