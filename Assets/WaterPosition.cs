using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterPosition : MonoBehaviour
{
    public GameManager gameManager;
    private Quaternion rotation;
    private Vector3 position;
    // Start is called before the first frame update
    void Start()
    {
        position = new Vector3(19.08229f, -4.566911f, 9.120253f);
        transform.position = position;

        rotation = new Quaternion(0, 1, 0, -0.5f);
        transform.rotation = rotation;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(transform.rotation);
        // if(gameManager.state == GameManager.StateType.BUCKET_FILL) {
        //     rotation = GameObject.Find("Valve").transform.rotation;
        //     Debug.Log(rotation);
        //     if(rotation.y - initialRotation.y > 0.5) {
        //         gameManager.state = GameManager.StateType.BUCKET_FILL;
        //     }
        // }
        
    }
}
