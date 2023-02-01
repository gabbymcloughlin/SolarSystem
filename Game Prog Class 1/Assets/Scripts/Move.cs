using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   // Moving shape the X position and multiplying by deltaTime so it moves the same on all computers
        
        transform.Rotate(Vector3.right * 25 * Time.deltaTime);
    }
}
