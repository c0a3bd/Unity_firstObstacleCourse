using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    // Start is called before the first frame update

    private void OnCollisionEnter(Collision other) 
    {
        Debug.Log("You've hit the walls");

    }


}
