using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ex8 : MonoBehaviour
{
    public int year;
    void Start()
    {
        IsLeapYear(year);
    }

    private bool IsLeapYear(int y)
    {
        if (year % 4 == 0 && year % 100 != 0 ||year % 400 == 0)
        {
            Debug.Log($"{year} is a leap year");
            return true;
        }
            Debug.Log($"{year} isn't a leap year");    
            return false;    
    }
}