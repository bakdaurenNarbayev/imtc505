using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ValveRotation : MonoBehaviour
{
    private Quaternion initialRotation, rotation;
    // Start is called before the first frame update
    void Start()
    {
        initialRotation = GameObject.Find("Valve").transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        rotation = GameObject.Find("Valve").transform.rotation;
        
        rotation.x = initialRotation.x;
        rotation.z = initialRotation.z;

        if(rotation.y - initialRotation.y < 0)
        {
            rotation.y = initialRotation.y;
        }

        if (rotation.y - initialRotation.y > 0.5)
        {
            rotation.y = initialRotation.y + 0.5f;
            Debug.Log("GM CALL: VALVE -> FILL FOUNTAIN");
        }

        GameObject.Find("Valve").transform.rotation = rotation;
    }
}
