using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ex5 : MonoBehaviour
{
    private int x;
    public int y;
    private int result;
  void Start()
    {
        MultiplicationTable(x, y);
    }
     private void MultiplicationTable(int x, int y)
       {
        for(x=0; x < 11; x++)
        {
            result = x * y;
            Debug.Log ($"{y} * {x} = {result}");
        }
       }  
}     