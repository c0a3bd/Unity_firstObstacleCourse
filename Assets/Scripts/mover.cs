using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover : MonoBehaviour
{
    [SerializeField] public float speed = 7f;

    void Start() 
    {
        PrintInstructions();
    }

    // Update is called once per frame
    void Update()
    {
        movePlayer();
    }


    void PrintInstructions() 
    {
        Debug.Log("Game Instructions");
        Debug.Log("Move around using the arrow keys"); 
        Debug.Log("Move around the maze and collect all of the red balls while avoiding the blue balls");
    }

    void movePlayer()
    {
        float xValue =  Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * speed; 

        transform.Translate(xValue, 0, zValue);
    }

}
