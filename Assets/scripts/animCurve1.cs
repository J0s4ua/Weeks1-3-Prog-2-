using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animCurve1 : MonoBehaviour
{
    // Start is called before the first frame update

    public AnimationCurve curve;
    public float t = 1f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        

        transform.localScale = Vector2.one * curve.Evaluate(t);


    }
}
