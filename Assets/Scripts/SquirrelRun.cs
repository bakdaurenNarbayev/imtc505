using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquirrelRun : MonoBehaviour
{
    private bool isShown = false;
    private bool isRunning = false;
    private bool isClose = false;
    public GameObject objectToActivate;
    public GameObject fountain;
    public float speed = 0.01f;
    public float closeness = 5f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerPosition = GameObject.Find("Main Camera").transform.position;
        Vector3 position = transform.position;
        Vector3 fountainPosition = fountain.transform.position;

        if(playerPosition.x - position.x < closeness && playerPosition.x - position.x > -closeness)
        {
            if (playerPosition.z - position.z < closeness && playerPosition.z - position.z > -closeness)
            {
                isClose = true;
            }
        }

        if(isClose)
        {
            if (position.x - fountainPosition.x > speed)
            {
                position.x -= speed;
                isRunning = true;
            }
            else if (position.x - fountainPosition.x < -speed)
            {
                position.x += speed;
                isRunning = true;
            }

            if (position.z - fountainPosition.z > speed)
            {
                position.z -= speed;
                isRunning = true;
            }
            else if (position.z - fountainPosition.z < -speed)
            {
                position.z += speed;
                isRunning = true;
            }

            if (!isRunning && !isShown)
            {
                if (objectToActivate != null)
                {
                    // Set the active state of the object
                    objectToActivate.SetActive(true);
                }
                else
                {
                    Debug.LogError("Object was not assigned.");
                }
                isShown = true;
            }
        }
        
        transform.position = position;
        isClose = false;
        isRunning = false;
    }
}
