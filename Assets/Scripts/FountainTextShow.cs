using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FountainTextShow : MonoBehaviour
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
        if (gameManager.state == GameManager.StateType.FOUNTAIN_TEXT)
        {
            objectToActivate.SetActive(true);
            objectToActivate = null;
            gameManager.state = GameManager.StateType.VALVE_FIX;
        }
    }
}