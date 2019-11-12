using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turns : MonoBehaviour
{
    public static Transform [] turnPositions;

    void Awake()
    {
        turnPositions = new Transform [transform.childCount];

        for (int i = 0; i < turnPositions.Length; i++)
        {
            turnPositions[i] = transform.GetChild(i);
        }
    }
}
