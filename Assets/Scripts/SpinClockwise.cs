using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinClockwise : MonoBehaviour
{
    [SerializeField] float SpinSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, SpinSpeed * Time.deltaTime, 0);
    }
}
