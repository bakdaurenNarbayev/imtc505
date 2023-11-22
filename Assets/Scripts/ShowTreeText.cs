using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowTreeText : MonoBehaviour
{
    private GameObject objectToActivate;
    public GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        objectToActivate = transform.GetChild(0).gameObject;
        objectToActivate.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (gameManager.state == GameManager.StateType.TREE_TEXT)
        {
            objectToActivate.SetActive(true);
            // gameManager.state = GameManager.StateType.VALVE_FIX;
        }
    }
}
