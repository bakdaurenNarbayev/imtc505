using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BucketFill : MonoBehaviour
{
    public GameManager gameManager;
    public Transform water, bucketWater;
    private float detectionRadius = 2f;
    private Vector3 position, scale;
    private int count = 1;

    void Update()
    {
        if(transform.position.y <= -0.3f) {
            position = transform.position;
            position.y = -0.3f;
            transform.position = position;
        }

        if(gameManager.state == GameManager.StateType.BUCKET_FILL) {
            foreach (Transform child in water)
            {
                float distance = Vector3.Distance(child.position, transform.position);

                if (distance < detectionRadius && transform.position.y <= 0f)
                {
                    position = bucketWater.position;
                    position.y = -0.1f-transform.position.y;
                    bucketWater.position = position;
                    
                    if(transform.position.y <= -0.2f) {
                        position = transform.position;
                        position.y = -0.2f;
                        transform.position = position;

                        gameManager.state = GameManager.StateType.SQUIRREL_RUN_AGAIN;
                    }
                    
                    break;
                }
            }
        }
    }
}
