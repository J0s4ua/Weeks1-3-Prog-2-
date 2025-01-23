using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using Unity.VisualScripting;
using UnityEngine;

public class Trick_Shot_1 : MonoBehaviour
{
    // Start is called before the first frame update

    float speed = 1f;
    float direction2 = 1f;
    public AnimationCurve jump;
    public AnimationCurve spin;
    public float t = 0f;
 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        Vector3 direction = transform.eulerAngles;
        Vector2 screenPos = Camera.main.WorldToScreenPoint(pos);

        if (screenPos.x < 0 || screenPos.x > Screen.width) {

            speed = -speed;
            print("bounced off screen");
            direction2 = -direction2;
        
        }

        



            
            pos.x += speed*0.5f;
            pos.y = jump.Evaluate(t);

            transform.position = pos;
        if (t >= 1)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                
                t = 0;


            }
        }

        if (t < 1) {

            t += 0.01f;
            print("jumped");
            transform.position = Vector3.up * jump.Evaluate(t) + pos;
            pos.y = jump.Evaluate(t);
            direction.z = (90 * spin.Evaluate(t) * -direction2);

            transform.eulerAngles = direction;

        }






    }
}
