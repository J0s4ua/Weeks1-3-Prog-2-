using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinning_tentacles_2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()


    {
        //makes the tentacles on the eye spin

        Vector3 rotation = transform.eulerAngles;
        rotation.z += 2;

        transform.eulerAngles = rotation;
    }
}
