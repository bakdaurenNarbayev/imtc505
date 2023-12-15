using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SyilxTextShow : MonoBehaviour
{
    private GameManager gameManager;
    private GameObject objectToActivate;

    void Start()
    {
        gameManager = (GameManager)FindObjectOfType(typeof(GameManager));

        objectToActivate = transform.GetChild(0).gameObject;
        objectToActivate.SetActive(false);
    }

    void Update()
    {
        if (gameManager.state == GameManager.StateType.SYILX_TEXT)
        {
            objectToActivate.SetActive(true);
            gameManager.state = GameManager.StateType.PUZZLE_SHOW;
        }
    }
}