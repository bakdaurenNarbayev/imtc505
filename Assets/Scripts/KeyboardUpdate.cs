using CW.Common;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Windows;

public class KeyboardUpdate : MonoBehaviour
{
    private GameManager gameManager;
    private TextMeshProUGUI input, mainText;
    private GameObject objectToActivate;
    private float closeness = 5f;
    Vector3 playerPosition;
    private GameObject manhole;

    void Start()
    {
        gameManager = (GameManager)FindObjectOfType(typeof(GameManager));
        input = GameObject.Find("Input").GetComponent<TextMeshProUGUI>();
        mainText = GameObject.Find("Main Text").GetComponent<TextMeshProUGUI>();

        objectToActivate = transform.GetChild(0).gameObject;
        objectToActivate.SetActive(false);

        manhole = GameObject.Find("Manhole(Clone)");
    }

    void Update()
    {
        if (gameManager.state == GameManager.StateType.PASSWORD_ENTER)
        {
            playerPosition = GameObject.Find("Main Camera").transform.position;

            if (Vector3.Distance(manhole.transform.position, playerPosition) < closeness)
            {
                objectToActivate.SetActive(true);
            }
        }
    }

    public void KeyPressed(string c)
    {
        input.text += c;
    }

    public void BackspacePressed()
    {
        if (!string.IsNullOrEmpty(input.text))
        {
            input.text = input.text.Substring(0, input.text.Length - 1);
        }
    }

    public void EnterPressed()
    {
        if(input.text == "DING")
        {
            gameManager.state = GameManager.StateType.END_PARTII_TEXT;
            objectToActivate.SetActive(false);
        } else
        {
            mainText.text = "Please, try again:";
            input.text = "";
        }
        
    }
}
