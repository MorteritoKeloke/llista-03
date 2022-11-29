using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ex3 : MonoBehaviour
{
    public int x;
    public int y;

    void Start()
    {
        IsExact(x, y);
    }


    private void IsExact(int x, int y)
    {
        if (x % y == 0)
        {
            Debug.Log($"The division is exact");
        }
        Debug.Log($"The division isn't exact");
    }
}