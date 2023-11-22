using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipLand : MonoBehaviour
{
    private GameManager gameManager;
    private float speed = 0.025f;
    private float groundLevel = 1.5f;

    void State()
    {
        Debug.Log("Here");
        //gameManager = (GameManager)FindObjectOfType(typeof(GameManager));
        //Debug.Log(gameManager);
    }

    // Update is called once per frame
    void Update()
    {
        if(gameManager.state == GameManager.StateType.SHIP_LAND)
        {
            Vector3 position = transform.position;
            if (position.y - groundLevel > speed)
            {
                position.y -= speed;
            }
            else
            {
                gameManager.state = GameManager.StateType.INTRO_TEXT;
            }
            transform.position = position;
        }

        Debug.Log("Ship state is");
        Debug.Log(gameManager.state);
    }
}
