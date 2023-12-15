using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BucketFill : MonoBehaviour
{
    private Transform water, bucketWater;
    private GameManager gameManager;
    private float detectionRadius = 1f;
    private Vector3 position;

    void Start()
    {
        gameManager = (GameManager)FindObjectOfType(typeof(GameManager));
        water = GameObject.Find("Water(Clone)").transform;
        bucketWater = GameObject.Find("BucketWater").transform;
    }

    void Update()
    {
        if (transform.position.y <= -0.5f)
        {
            position = transform.position;
            position.y = -0.5f;
            transform.position = position;
        }

        if (gameManager.state == GameManager.StateType.BUCKET_FILL)
        {
            foreach (Transform child in water)
            {
                float distance = Vector3.Distance(child.position, transform.position);

                Debug.Log(distance);

                if (distance < detectionRadius)
                {
                    position = bucketWater.localPosition;
                    position.y = 0.25f;
                    bucketWater.localPosition = position;

                    gameManager.state = GameManager.StateType.SQUIRREL_RUN_AGAIN;

                    break;
                }
            }
        }
    }
}
