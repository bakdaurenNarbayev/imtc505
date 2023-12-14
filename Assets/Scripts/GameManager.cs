using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public enum StateType
    {
        SHIP_LAND,
        INTRO_TEXT,
        SQUIRREL_RUN,
        FOUNTAIN_TEXT,
        VALVE_FIX,
        WATER_FILL,
        BUCKET_FILL,
        SQUIRREL_RUN_AGAIN,
        TREE_TEXT
    };

    public StateType state = StateType.SHIP_LAND;

    private void Update()
    {
/*        if (state != StateType.WATER_FILL)
        {
            state = StateType.VALVE_FIX;
        }*/
        Debug.Log(state);
    }
}