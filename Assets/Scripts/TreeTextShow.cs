using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeTextShow : MonoBehaviour
{
    private GameManager gameManager;
    private GameObject objectToActivate;
    Vector3 playerPosition;

    void Start()
    {
        gameManager = (GameManager)FindObjectOfType(typeof(GameManager));

        objectToActivate = transform.GetChild(0).gameObject;
        objectToActivate.SetActive(false);
    }

    void Update()
    {
        if (gameManager.state == GameManager.StateType.TREE_TEXT)
        {
            playerPosition = GameObject.Find("Main Camera").transform.position;

            if (playerPosition.x > 18.5f && playerPosition.x < 22.5f)
            {
                if (playerPosition.z > -2.5f && playerPosition.z < 2.5f)
                {
                    objectToActivate.SetActive(true);
                    objectToActivate = null;
                    gameManager.state = GameManager.StateType.WATER_POUR;
                }
            }
        }
    }
}