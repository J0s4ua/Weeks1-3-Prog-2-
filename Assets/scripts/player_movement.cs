using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEditor;
using UnityEngine;

public class player_movement : MonoBehaviour
{
    public AnimationCurve Jump;
    public float t = 1f;
    float gravity = 1f;
    float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        Vector3 player_movement = transform.position;

        //player horizontal movement
        player_movement.x += Input.GetAxis("Horizontal") * speed * Time.deltaTime;


        //player gravity (makes sure the player stays at that specific Y level)

        player_movement.y = -3;

        //makes the player jump

        if (Input.GetMouseButtonDown(0) == true) {

            if (t >= 1) { 
            t = 0;
        }

        }

        //plays the animation if T is less than 1

        if (t <= 1)
        {

            t += 2f * Time.deltaTime;

        }


        



            //sets the location of the player
            transform.position = Vector3.up * Jump.Evaluate(t) + player_movement;

        
    }
}
