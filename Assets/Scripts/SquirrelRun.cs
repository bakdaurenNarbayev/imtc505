 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquirrelRun : MonoBehaviour
{
    public GameObject fountain;
    public GameObject wp1, wp2, wp3, wp4;
    public float speed = 0.01f;
    public float closeness = 5f;
    public float goalCloseness = 2f;
    public GameManager gameManager;
    private int count = 1;

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

        // if(gameManager.state == GameManager.StateType.TREE_WATER) {
        //     Vector3 position = transform.position;
        //     Vector3 wpPosition = wp1.transform.position;

        //     switch(count) {
        //         case 1:
        //         case 2:
        //         case 3:
        //         case 4:
        //     }

           

        //     Vector3 movement = (fountainPosition - position).normalized;

        //     if (Vector3.Distance(position, playerPosition) < closeness)
        //     {
        //         if(Vector3.Distance(position, fountainPosition) > goalCloseness)
        //         {
        //             position = position + speed * movement;
        //         } else {
        //             gameManager.state = GameManager.StateType.FOUNTAIN_TEXT;
        //         }
        //     }

        //     transform.position = position;
        // }
    }
}
