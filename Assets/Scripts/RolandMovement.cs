using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RolandMovement : MonoBehaviour
{
    float hor, ver;
 
    [SerializeField] float movespeed;
    [SerializeField] float JumpStrength;


    void Start()
    {
        PrintInstructions();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer(); 
    }

    void PrintInstructions()
    {
        Debug.Log("Welcome to the game !");
       
        Debug.Log("Move Roland with WASD keys or UP,DOWN,LEFT,RIGHT arrow keys");
    }

    void MovePlayer()
    {
        ver = Input.GetAxis("Vertical");
        hor = Input.GetAxis("Horizontal");

        transform.Translate(hor * movespeed * Time.deltaTime, 0, ver * movespeed * Time.deltaTime);
    }
 
    

}
