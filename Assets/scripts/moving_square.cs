using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class moving_square : MonoBehaviour
{
    // Start is called before the first frame update
    float speed = 0.1f;
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
        Vector3 pos = transform.position;
        pos.x += speed;

        Vector2 ScreenPos = Camera.main.WorldToScreenPoint(pos);

        if (ScreenPos.x < 0 || ScreenPos.x > Screen.width) {

            speed = -speed;
        
        }

        transform.position = pos;

    }
}
