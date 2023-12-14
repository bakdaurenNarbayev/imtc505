using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipLanding : MonoBehaviour
{
    private GameManager gameManager;
    private float speed = 0.05f;
    private float groundLevel = 3f;

    void Start()
    {
        gameManager = (GameManager)FindObjectOfType(typeof(GameManager));
    }

    // Update is called once per frame
    void Update()
    {
        if (gameManager.state == GameManager.StateType.SHIP_LAND)
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
