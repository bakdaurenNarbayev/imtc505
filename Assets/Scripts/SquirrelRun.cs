 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquirrelRun : MonoBehaviour
{
    public GameObject fountain;
    public float speed = 0.01f;
    public float closeness = 5f;
    public float goalCloseness = 2f;
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

            Vector3 movement = (fountainPosition - position).normalized;

            if (Vector3.Distance(position, playerPosition) < closeness)
            {
                if(Vector3.Distance(position, fountainPosition) > goalCloseness)
                {
                    position = position + speed * movement;
                } else {
                    gameManager.state = GameManager.StateType.FOUNTAIN_TEXT;
                }
            }

            transform.position = position;
        }
    }
}
