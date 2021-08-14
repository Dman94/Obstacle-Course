using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Droper : MonoBehaviour
{
    MeshRenderer Renderer;                                 //<< Creating  a MeshRenderer Variable to store our value in
    Rigidbody Rb;                                         // << Crating a RigidBody Variable to store our value in

    [SerializeField] float TimetoWait = 5f; 
    


    //Called before the first frame of the scene
    void Start()
    {
        Renderer = GetComponent<MeshRenderer>();            //<< caching a refference value for easy access (or storing the MeshRender component in  our variable)
        Rb = GetComponent<Rigidbody>();                    //<< same thing happening her but for the RigidBody Component

        Renderer.enabled = false;                          //<< disables the meshrenderer component
        Rb.useGravity = false;                             //<< disables the gravity of the rigidbody component
        
    }

  //called for every frame 
    void Update()
    {
       
      if(Time.time > TimetoWait)  /// timer function
        {
                                        // Debug.Log("3 seconds has elapsed");    << we use the debug.log first to test if our timer is working then once we know it dos we no longer need it
            Renderer.enabled = true;
            Rb.useGravity = true;
            
        }
    }
    void OnCollisionEnter(Collision other)  // this parameter inspects the specified information of the other object it knocks into
    {
        if (other.gameObject.tag == "Player")   // setting the tag for only to change color when player contacts
        {
            Renderer.material.color = Color.red;
            gameObject.tag = "Hit";
        }
       

        
    }
}
