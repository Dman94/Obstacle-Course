using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopCorn : MonoBehaviour
{
    Rigidbody Rb;
    [SerializeField] float PopStrength;
    [SerializeField] float TimetoWait = 5f;
    [SerializeField] float IncrimentedValue;

    // Start is called before the first frame update
    void Start()
    {
        Rb = GetComponent<Rigidbody>();
        
    }
    // Update is called once per frame
    private void FixedUpdate()
    {
     

        if (Time.time > TimetoWait)
        {
            TimetoWait = TimetoWait + IncrimentedValue;
            Rb.AddForce(0, PopStrength * Time.fixedDeltaTime, 0);
            
        }
      

    }
    
}
