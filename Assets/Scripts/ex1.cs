using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ex1 : MonoBehaviour
{
    public string letter;
    void Start()
    {
        IsVowel(letter);
    }
    private bool IsVowel(string x)
    {
        if(x == "a" ||x ==  "e" ||x ==  "i" ||x == "o" || x == "u")
        {
            Debug.Log($"The letter {x} is a vowel");
            return true;
        }
            Debug.Log($"The letter {x} isn't a vowel");
            return false;
    }
}
