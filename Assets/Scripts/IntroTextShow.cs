using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroTextShow : MonoBehaviour
{
    private GameManager gameManager;
    private GameObject objectToActivate;
    
    // Start is called before the first frame update
    void Start()
    {
        gameManager = (GameManager)FindObjectOfType(typeof(GameManager));

        objectToActivate = transform.GetChild(0).gameObject;
        objectToActivate.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (gameManager.state == GameManager.StateType.INTRO_TEXT)
        {
            objectToActivate.SetActive(true);
            gameManager.state = GameManager.StateType.SQUIRREL_RUN;
        }
    }
}