using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ValveRotation : MonoBehaviour
{
    private GameManager gameManager;
    private Quaternion initialRotation, rotation;
    private Transform targetPoF, PoF;

    void Start()
    {
        gameManager = (GameManager)FindObjectOfType(typeof(GameManager));
        initialRotation = GameObject.Find("Valve").transform.rotation;
        targetPoF = GameObject.Find("TargetPoF").transform;
    }

    void Update()
    {
        if (gameManager.state == GameManager.StateType.VALVE_FIX)
        {
            rotation = GameObject.Find("Valve").transform.rotation;
            PoF = GameObject.Find("PoF").transform;

            rotation.x = initialRotation.x;
            rotation.z = initialRotation.z;

            if (rotation.y - initialRotation.y < 0)
            {
                rotation.y = initialRotation.y;
            }

            if (Vector3.Distance(PoF.position, targetPoF.position) < 0.126f)
            {
                gameManager.state = GameManager.StateType.WATER_FILL;
                initialRotation = rotation;
            }

            GameObject.Find("Valve").transform.rotation = rotation;
        } else
        {
            GameObject.Find("Valve").transform.rotation = initialRotation;
        }
    }
}
