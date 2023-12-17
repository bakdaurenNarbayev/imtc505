using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquirrelRun : MonoBehaviour
{
    private GameManager gameManager;
    private GameObject wp1, wp2, wp3, wp4, wp5;
    private float speed = 0.015f;
    private float closeness = 5f;
    private float goalCloseness = 2f;
    Vector3 playerPosition, position, fountainPosition, wpPosition, movement;
    private int count = 1;

    void Start()
    {
        gameManager = (GameManager)FindObjectOfType(typeof(GameManager));
        fountainPosition = GameObject.Find("FountainValve(Clone)").transform.position;
        wp1 = GameObject.Find("WP1(Clone)");
        wp2 = GameObject.Find("WP2(Clone)");
        wp3 = GameObject.Find("WP3(Clone)");
        wp4 = GameObject.Find("WP4(Clone)");
        wp5 = GameObject.Find("WP5(Clone)");
    }

    void Update()
    {
        if (gameManager.state == GameManager.StateType.SQUIRREL_RUN)
        {
            playerPosition = GameObject.Find("Main Camera").transform.position;
            position = transform.position;

            transform.LookAt(fountainPosition);
            movement = (fountainPosition - position).normalized;

            if (Vector3.Distance(position, playerPosition) < closeness)
            {
                if (Vector3.Distance(position, fountainPosition) > goalCloseness)
                {
                    position = position + speed * movement;
                    position.y = 0;
                }
                else
                {
                    position.y = 0;
                    transform.position = position;
                    gameManager.state = GameManager.StateType.FOUNTAIN_TEXT;
                }
            }

            transform.position = position;
        }

        if (gameManager.state == GameManager.StateType.SQUIRREL_RUN_AGAIN)
        {
            position = transform.position;
            wpPosition = wp1.transform.position;

            switch (count)
            {
                case 1:
                    break;
                case 2:
                    wpPosition = wp2.transform.position;
                    break;
                case 3:
                    wpPosition = wp3.transform.position;
                    break;
                case 4:
                    wpPosition = wp4.transform.position;
                    break;
                default:
                    break;
            }

            if (count > 4)
            {
                gameManager.state = GameManager.StateType.TREE_TEXT;
                return;
            }

            transform.LookAt(wpPosition);
            movement = (wpPosition - position).normalized;

            if (Vector3.Distance(position, wpPosition) > goalCloseness)
            {
                position = position + speed * movement;
            }
            else
            {
                count++;
            }

            position.y = 0;
            transform.position = position;
        }

        if (gameManager.state == GameManager.StateType.SQUIRREL_RUN_AGAIN_X2)
        {
            position = transform.position;
            wpPosition = wp3.transform.position;

            switch (count)
            {
                case 5:
                    break;
                case 6:
                    wpPosition = wp2.transform.position;
                    break;
                case 7:
                    wpPosition = wp5.transform.position;
                    break;
                default:
                    break;
            }

            if (count > 7)
            {
                gameManager.state = GameManager.StateType.SYILX_TEXT;
                return;
            }

            transform.LookAt(wpPosition);
            movement = (wpPosition - position).normalized;

            if (Vector3.Distance(position, wpPosition) > goalCloseness)
            {
                position = position + speed * movement;
            }
            else
            {
                count++;
            }

            position.y = 0;
            transform.position = position;
        }
    }
}
