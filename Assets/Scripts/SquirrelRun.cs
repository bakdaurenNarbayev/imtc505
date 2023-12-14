using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquirrelRun : MonoBehaviour
{
    private GameManager gameManager;
    private float speed = 0.01f;
    private float closeness = 5f;
    private float goalCloseness = 2f;

    void Start()
    {
        gameManager = (GameManager)FindObjectOfType(typeof(GameManager));
    }

    // Update is called once per frame
    void Update()
    {
        if (gameManager.state == GameManager.StateType.SQUIRREL_RUN)
        {
            Vector3 playerPosition = GameObject.Find("Main Camera").transform.position;
            Vector3 position = transform.position;
            Vector3 fountainPosition = GameObject.Find("FountainValve(Clone)").transform.position;

            Vector3 movement = (fountainPosition - position).normalized;

            if (Vector3.Distance(position, playerPosition) < closeness)
            {
                if (Vector3.Distance(position, fountainPosition) > goalCloseness)
                {
                    position = position + speed * movement;
                    position.y = 0;
                }
                else
                {
                    gameManager.state = GameManager.StateType.FOUNTAIN_TEXT;
                }
            }

            transform.position = position;
        }
    }
}
