 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquirrelRun : MonoBehaviour
{
    private bool isRunning = false;
    private bool isClose = false;
    public GameObject fountain;
    public float speed = 0.01f;
    public float closeness = 5f;
    public GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 position = transform.position;
        position.y = 0;
        transform.position = position;
    }

    // Update is called once per frame
    void Update()
    {
        if(gameManager.state == GameManager.StateType.SQUIRREL_RUN)
        {
            Vector3 playerPosition = GameObject.Find("Main Camera").transform.position;
            Vector3 position = transform.position;
            Vector3 fountainPosition = fountain.transform.position;

            if (playerPosition.x - position.x < closeness && playerPosition.x - position.x > -closeness)
            {
                if (playerPosition.z - position.z < closeness && playerPosition.z - position.z > -closeness)
                {
                    isClose = true;
                }
            }

            if (isClose)
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

                if (!isRunning)
                {
                    gameManager.state = GameManager.StateType.FOUNTAIN_TEXT;
                }
            }

            transform.position = position;
            isClose = false;
            isRunning = false;
        }
    }
}
