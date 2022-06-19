using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropObstacles : MonoBehaviour
{
    MeshRenderer renderer;    // type and variable
    Rigidbody gravity;    // type and variable
    [SerializeField] float dropBlockInterval = 3f;

    // Start is called before the first frame update
    void Start()
    {
        holdDropBlocks();
    }

    // Update is called once per frame
    void Update()

    {
        dropBlocks();
    }

    void dropBlocks()
    {
        if (Time.time > dropBlockInterval)
        {
            // show to player
            renderer.enabled = true;

            // make hanging block drop
            gravity.useGravity = true;
        }
    }

    void holdDropBlocks()
    {
        // Caching a reference to improve performance and call easier
        renderer = GetComponent<MeshRenderer>();
        gravity = GetComponent<Rigidbody>();

        // make block invisible to player
        renderer.enabled = false;

        // make block hang in the air
        gravity.useGravity = false;
    }


}
