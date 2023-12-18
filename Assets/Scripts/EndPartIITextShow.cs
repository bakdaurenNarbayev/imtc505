using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndPartIITextShow : MonoBehaviour
{
    private GameManager gameManager;
    private GameObject objectToActivate;
    private float closeness = 5f;
    Vector3 playerPosition;
    private GameObject monument;

    void Start()
    {
        gameManager = (GameManager)FindObjectOfType(typeof(GameManager));

        objectToActivate = transform.GetChild(0).gameObject;
        objectToActivate.SetActive(false);

        monument = GameObject.Find("Manhole(Clone)");
    }

    void Update()
    {
        if (gameManager.state == GameManager.StateType.END_PARTII_TEXT)
        {
            playerPosition = GameObject.Find("Main Camera").transform.position;

            if (Vector3.Distance(monument.transform.position, playerPosition) < closeness)
            {
                objectToActivate.SetActive(true);
                objectToActivate = null;
                gameManager.state = GameManager.StateType.END;
            }
        }
    }
}