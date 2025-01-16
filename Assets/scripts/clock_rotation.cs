using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class clock_rotation : MonoBehaviour
{
    // Start is called before the first frame update

    public float speed = 0.1f;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 rotSpeed = transform.eulerAngles;

        rotSpeed.z += speed;

        transform.eulerAngles = rotSpeed;
    }
}
