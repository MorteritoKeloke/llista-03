using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ex10 : MonoBehaviour
{
  void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            Axes();
        }
    }

    private void Axes()
    {
        transform.localScale += Vector3.one;
    }
}

