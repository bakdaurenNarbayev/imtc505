using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ValveRotation : MonoBehaviour
{
    private GameManager gameManager;
    private Quaternion initialRotation, rotation;

    void Start()
    {
        gameManager = (GameManager)FindObjectOfType(typeof(GameManager));
        initialRotation = GameObject.Find("Valve").transform.rotation;
    }

    void Update()
    {
        if (gameManager.state == GameManager.StateType.VALVE_FIX)
        {
            rotation = GameObject.Find("Valve").transform.rotation;

            rotation.x = initialRotation.x;
            rotation.z = initialRotation.z;

            if (rotation.y - initialRotation.y < 0)
            {
                rotation.y = initialRotation.y;
            }

            Debug.Log(rotation.y - initialRotation.y);

            if (rotation.y - initialRotation.y > 1f)
            {
                rotation.y = Mathf.Min(initialRotation.y + 1.1f, rotation.y);
                gameManager.state = GameManager.StateType.WATER_FILL;
            }

            GameObject.Find("Valve").transform.rotation = rotation;
        } else
        {
            GameObject.Find("Valve").transform.rotation = initialRotation;
        }
    }
}
