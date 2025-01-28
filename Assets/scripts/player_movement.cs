using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class player_movement : MonoBehaviour
{
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

        if (player_movement.y < -2.7)
        {

            player_movement.y = -2.7f;
            

        }
        else {


            player_movement.y -= 1;

        }

        //sets the location of the player

        transform.position = player_movement;
    }
}
