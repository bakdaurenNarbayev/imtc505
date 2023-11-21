using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipLand : MonoBehaviour
{
    public GameManager gameManager;
    
    private float speed = 0.025f;
    private float groundLevel = 1.5f;

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
    }
}
