using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rollBall : MonoBehaviour
{
    public float roll = .05f;
    public float bump = .05f;
    public Rigidbody rb; 

    // Start is called before the first frame update
    void Start()
    {
        rollingBall();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void rollingBall()
    {
        
        rb = GetComponent<Rigidbody>();
        rb.AddForce(roll, 0, 0);
    }
}
