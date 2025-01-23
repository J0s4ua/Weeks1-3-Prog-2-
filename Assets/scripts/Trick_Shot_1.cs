using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using Unity.VisualScripting;
using UnityEngine;

public class Trick_Shot_1 : MonoBehaviour
{
    // Start is called before the first frame update

    float speed = 0.1f;
    public AnimationCurve jump;
    public float t = 10f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        Vector2 screenPos = Camera.main.WorldToScreenPoint(pos);

        if (screenPos.x < 0 || screenPos.x > Screen.width) {

            speed = -speed;
            print("bounced off screen");
        
        }

        



            
            pos.x += speed;
            
        transform.position = pos;

        if (Input.GetKey(KeyCode.Space))
        {

            print("jumped");
            transform.position = Vector3.up * jump.Evaluate(t) + pos;

        }






    }
}
