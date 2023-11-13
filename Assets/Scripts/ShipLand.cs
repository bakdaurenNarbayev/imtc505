using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipLand : MonoBehaviour
{
    public float speed = 0.05f;
    public float groundLevel = 0f;
    public GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        
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
