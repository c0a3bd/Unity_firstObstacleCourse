using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spinObstacle : MonoBehaviour
{
    [SerializeField] float ySpinIdle = 6f;
    [SerializeField] float ySpinHit = 25f;
    [SerializeField] float xSpinIdle = 0f;
    [SerializeField] float zSpinIdle = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        spinBlock();        
    }

    void spinBlock()
    {
        if (gameObject.tag != "ObjectHit")
        {
            transform.Rotate(xSpinIdle, ySpinIdle, zSpinIdle);
        }
        else
        {
            transform.Rotate(xSpinIdle, ySpinHit, zSpinIdle);
        }
    }
}
