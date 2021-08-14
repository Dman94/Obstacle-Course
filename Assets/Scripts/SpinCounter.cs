using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinCounter : MonoBehaviour
{
    [SerializeField] float SpinSpeed;
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, -SpinSpeed * Time.deltaTime, 0);
    }
}
