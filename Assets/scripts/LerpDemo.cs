using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpDemo : MonoBehaviour
{
    // Start is called before the first frame update

    public float t;
    public AnimationCurve curve;
    public Transform start;
    public Transform end;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.Lerp(start.position, end.position, curve.Evaluate(t));
    }
}
