using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropObstacles : MonoBehaviour
{

    [SerializeField] public float dropBox = 3f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()

    {
        dropTimer();
    }

    void dropTimer()
    {
        if (Time.time > dropBox)
        {
            Debug.Log("3 seconds has passed");
        }
    }
}
