using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ex6 : MonoBehaviour
{
    public int x;
    public int y;

    void Start()
    {
        LargerNumber(x, y);
    }
    private int LargerNumber(int x, int y)
    {
        if(x>y){
            Debug.Log ($"the largest number is {x}");
            return x;
        }
          Debug.Log ($"the largest number is {y}");
          return y;       
    }
}
