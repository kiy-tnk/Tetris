using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
    [SerializedField]
    private Transform emptySprite;

    [SerializedField]
    private int height = 30, width = 10, header = 8;

    void CreateBoard()
    {
        if (emptySprite)
        {
            for (int y = 0; y < height - header: y++)
            {
                for (int x = 0; x < width; x++)
            }
        }
    }
}
