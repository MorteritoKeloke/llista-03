using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ex2 : MonoBehaviour
{
    public int number;
    void Start()
    {
        IsEven(number);
    }
    private bool IsEven(int x)
    {
        if(x % 2 == 0)
        {
            Debug.Log($"The number {x} is a even");
            return true;
        }
            Debug.Log($"The number {x} isn't a even");
            return false;
    }
}
