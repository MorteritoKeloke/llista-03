using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ex4 : MonoBehaviour
{
    public Vector3 position;
    void Start()
    {
        Movement(position);
    }

    private void Movement(Vector3 x)
    {
        transform.position = x;
    }
}
