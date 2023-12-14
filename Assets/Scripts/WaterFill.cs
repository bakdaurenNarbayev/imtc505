using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterFill : MonoBehaviour
{
    private GameManager gameManager;
    private int count = 1;
    private Vector3 scale, initialPosition;

    void Start()
    {
        gameManager = (GameManager)FindObjectOfType(typeof(GameManager));
        initialPosition = transform.position;
    }

    void Update()
    {
        if (gameManager.state == GameManager.StateType.WATER_FILL)
        {
            if (count <= 1500 && count % 80 == 0)
            {
                foreach (Transform child in transform)
                {
                    scale = child.localScale;
                    scale.y = scale.y + 0.1f;
                    child.localScale = scale;
                }

                transform.position = initialPosition;
            }

            count++;

            if (count > 4500)
            {
                gameManager.state = GameManager.StateType.BUCKET_FILL;
            }
        }
    }
}
