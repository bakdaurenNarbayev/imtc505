using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePosition : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Vector3 position = transform.position;
        position.y = 1.5f;
        transform.position = position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
