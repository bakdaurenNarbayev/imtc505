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
        TREE_TEXT,
        WATER_POUR,
        TREE_WATER,
        SQUIRREL_RUN_AGAIN_X2,
        SYILX_TEXT,
        PUZZLE_SHOW,
        LAZER_SHOOT,
        PUZZLE_SOLVE
    };

    public StateType state = StateType.SHIP_LAND;

    private void Update()
    {
        if (state == StateType.SHIP_LAND)
        {
            state = StateType.SQUIRREL_RUN_AGAIN_X2;
        }
        Debug.Log(state);
    }
}