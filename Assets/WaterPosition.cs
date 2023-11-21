using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterPosition : MonoBehaviour
{
    public GameManager gameManager;
    private int count = 1;
    private Vector3 scale, initialPosition;

    void Start()
    {
        initialPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(gameManager.state == GameManager.StateType.WATER_FILL) {
            if(count <= 5000 && count % 250 == 0) {
                foreach (Transform child in transform)
                {
                    scale = child.localScale;
                    scale.y = scale.y + 0.1f;
                    child.localScale = scale;
                }

                transform.position = initialPosition;

                Debug.Log(transform.position);
                Debug.Log(scale);
                Debug.Log(transform.localScale);
            }
            count++;
        }
    }
}
