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
        initialRotation = GameObject.Find("Valve").transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        if(gameManager.state == GameManager.StateType.VALVE_FIX) {
            rotation = GameObject.Find("Valve").transform.rotation;
            if(rotation.y - initialRotation.y > 0.5) {
                gameManager.state = GameManager.StateType.WATER_FILL;
            }
        }
    }
}
