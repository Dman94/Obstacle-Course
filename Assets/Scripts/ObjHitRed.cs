using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjHitRed : MonoBehaviour
{
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            GetComponent<MeshRenderer>().material.color = Color.magenta;
            gameObject.tag = "Hit";

        }



    }

}
