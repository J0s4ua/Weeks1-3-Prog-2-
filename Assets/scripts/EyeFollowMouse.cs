using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EyeFollowMouse : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //follow mouse position
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3 Pos = transform.position;

        //contains the eye on the Left of the tank

        if (mousePos.x < -0.7) {

            mousePos.x = -0.7f;
        
        }

        //contains the eye on the Right of the tank

        if (mousePos.x > 0.7)
        {

            mousePos.x = 0.7f;

        }

        //contains the eye on the bottom of the tank

        if (mousePos.y < 0)
        {

            mousePos.y = 0;

        }

        //contains the eye on the top of the tank

        if (mousePos.y > 2.7)
        {

            mousePos.y = 2.7f;

        }


        //moves the eye
        transform.position = mousePos;
        
    }
}
