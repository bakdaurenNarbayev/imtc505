using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeWaterPosition : MonoBehaviour
{
    private GameManager gameManager;
    Vector3 position;
    int count = 0;

    void Start()
    {
        gameManager = (GameManager)FindObjectOfType(typeof(GameManager));
    }

    void Update()
    {
        if (gameManager.state == GameManager.StateType.TREE_WATER)
        {
            position = transform.position;
            count++;

            if(count <= 300)
            {
                position.y += 0.37f / 300;
            } else if(count > 700 && count <= 1000)
            {
                position.y -= 0.37f / 300;
            } else if(count > 1000)
            {
                gameManager.state = GameManager.StateType.SQUIRREL_RUN_AGAIN_X2;
            }

            transform.position = position;
        }
    }
}