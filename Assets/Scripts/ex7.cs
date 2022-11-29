using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ex7 : MonoBehaviour
{
    public int x;
    void Start()
    {
        AbsolutNumber(x);
    }
  
    private int AbsolutNumber(int x)
    {
       int y;
       if(x>=0){
       Debug.Log($"the absolut value of the number {x} is {x}");
       return x;
       }
       y= x * -1;
       Debug.Log($"the absolut value of the number {x} is {y}");
       return y;
    }
}
