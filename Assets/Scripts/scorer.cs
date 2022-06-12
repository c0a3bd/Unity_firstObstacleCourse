using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scorer : MonoBehaviour
{
    [SerializeField] int hit = 0;

    private void OnCollisionEnter(Collision other)
    {
        hit++;
        Debug.Log("Wall hit count: " + hit);
    }
}
