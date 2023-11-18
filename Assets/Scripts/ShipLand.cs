using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipLand : MonoBehaviour
{
    public GameManager gameManager;
    
    private float speed = 0.015f;
    private float groundLevel = 0f;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 position = transform.position;
        position.y = 30f;
        transform.position = position;
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
    }
}
