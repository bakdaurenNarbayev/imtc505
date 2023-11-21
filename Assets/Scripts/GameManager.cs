using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //private static GameManager instance;
    public enum StateType
    {
        SHIP_LAND,
        INTRO_TEXT,
        SQUIRREL_RUN,
        FOUNTAIN_TEXT,
        VALVE_FIX,
        WATER_FILL
    };
    
    public StateType state = StateType.SHIP_LAND;

    public GameObject env;

    void Start()
    {
        env.SetActive(false);
    }

    void Update()
    {
        //Debug.Log(state);
    }
}
