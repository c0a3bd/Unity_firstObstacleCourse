using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover : MonoBehaviour
{

    [SerializeField] public float speed = 5f;


    // Update is called once per frame
    void Update()
    {
        float xValue =  Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * speed; 

        transform.Translate(xValue, 0, zValue);

    }
}
