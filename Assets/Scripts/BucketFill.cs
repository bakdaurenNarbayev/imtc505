using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class BucketFill : MonoBehaviour
{
    private Transform water, bucketWater;
    private GameManager gameManager;
    private GameObject up, down;
    private float detectionRadius = 2f;
    private Vector3 position;
    private int count = 0;

    void Start()
    {
        gameManager = (GameManager)FindObjectOfType(typeof(GameManager));
        water = GameObject.Find("Water(Clone)").transform;
        bucketWater = GameObject.Find("BucketWater").transform;
        up = GameObject.Find("Up");
        down = GameObject.Find("Down");
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

        if (gameManager.state == GameManager.StateType.WATER_POUR)
        {
            Debug.Log(transform.position);
            Debug.Log(up.transform.position.y);
            Debug.Log(down.transform.position.y);
            if(transform.position.x > 18.5f && transform.position.x < 22.5f)
            {
                if(transform.position.z > -2.5f && transform.position.z < 2.5f)
                {
                    if (down.transform.position.y - up.transform.position.y > 0.2f)
                    {
                        count++;
                        if(count >= 120)
                        {
                            GameObject.Find("BucketWater").SetActive(false);
                            gameManager.state = GameManager.StateType.TREE_WATER;
                        }
                    }
                }
            }
        }
    }
}
