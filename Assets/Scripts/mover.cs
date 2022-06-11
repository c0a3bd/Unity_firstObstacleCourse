using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover : MonoBehaviour
{

    public float speed = .01f;


    // Update is called once per frame
    void Update()
    {
        float xValue =  Input.GetAxis("Horizontal") * speed;
        float zValue = Input.GetAxis("Vertical") * speed; 

        transform.Translate(xValue, 0, zValue);

    }
}
