using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LazerShoot : MonoBehaviour
{
    private GameManager gameManager;
    private float closeness = 5f;
    Vector3 playerPosition;
    private GameObject lazer;
    private int count = 0;

    void Start()
    {
        gameManager = (GameManager)FindObjectOfType(typeof(GameManager));
        lazer = GameObject.Find("Lazer");
    }

    void Update()
    {
        if (gameManager.state == GameManager.StateType.PUZZLE_SHOW)
        {
            playerPosition = GameObject.Find("Main Camera").transform.position;

            if (Vector3.Distance(transform.position, playerPosition) < closeness)
            {
                gameManager.state = GameManager.StateType.LAZER_SHOOT;
            }
        }

        if (gameManager.state == GameManager.StateType.LAZER_SHOOT)
        {
            count++;
            lazer.transform.localScale = new Vector3(0.1f, count / 100, 0.1f);
            lazer.transform.localPosition = new Vector3(0.063f, 2.14f - 0.04f * count / 100, -0.6f - count / 100);
            if (count >= 2000)
            {
                gameManager.state = GameManager.StateType.PUZZLE_SOLVE;
            }
        }
    }
}