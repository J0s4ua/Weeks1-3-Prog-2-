using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class closing_Left_wall : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        //THIS IS AN UNUSED SCRIPT
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 walls = transform.position;

        //checking where walls is in camera view
        Vector2 ScreenPos = Camera.main.WorldToScreenPoint(walls);

        if (Input.GetKeyDown(KeyCode.Space) == true) {


            walls.x += 0.01f;

            if (walls.x > -0.71)
            {

                walls.x = -0.7f;

            }

        }

        

        if (Input.GetKeyDown(KeyCode.Space) == false) {

            

            if (walls.x < -6.2)
            {

                walls.x = -6.2f;

            }
            else {

                walls.x -= 0.01f;

            }

        }

        

        
        transform.position = walls;
    }
}
