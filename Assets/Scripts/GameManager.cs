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
        END_PARTI_TEXT,
        PASSWORD_ENTER,
        END_PARTII_TEXT,
        END
    };

    public StateType state = StateType.SHIP_LAND;

    private void Start()
    {
        state = StateType.LAZER_SHOOT;
    }
    
    private void Update()
    {
        Debug.Log(state);
    }
}