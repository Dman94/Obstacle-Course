using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int hits;

    void Start()
    {
        hits = 0;
        Debug.Log("You've hit the wall this many times:"  + hits);
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag != "Hit" )
        {
            hits++;
            Debug.Log("You've hit the wall this many times: " + hits);
        }
       
    }

     
}
