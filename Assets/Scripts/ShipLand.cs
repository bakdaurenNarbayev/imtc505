using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipLand : MonoBehaviour
{
    private bool isShown = false;
    public GameObject objectToActivate;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 position = transform.position;
        if(position.y > 1)
        {
            position.y -= 0.05f;
        } else if(!isShown)
        {
            if (objectToActivate != null)
            {
                // Set the active state of the object
                objectToActivate.SetActive(true);
            }
            else
            {
                Debug.LogError("Object was not assigned.");
            }
            isShown = true;
        }
        transform.position = position;
    }
}
