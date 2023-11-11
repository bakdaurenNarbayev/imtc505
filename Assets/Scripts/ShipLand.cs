using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipLand : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 position = transform.position;
        if(position.y > 1)
        {
            position.y -= 0.05f;
        }
        transform.position = position;
    }
}
