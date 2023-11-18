using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ValvePosition : MonoBehaviour
{
    public GameManager gameManager;
    private Quaternion initialRotation, rotation;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 position = transform.position;
        position.y = 0;
        transform.position = position;

        initialRotation = GameObject.Find("Valve").transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        if(gameManager.state == GameManager.StateType.VALVE_FIX) {
            rotation = GameObject.Find("Valve").transform.rotation;
            if(rotation.y - initialRotation.y > 80) {
                gameManager.state = GameManager.StateType.BUCKET_FILL;
                Debug.Log("Finally");
            }
        }
        
    }
}
