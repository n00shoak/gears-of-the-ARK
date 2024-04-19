using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MN_PlayerData : CL_Manager
{
    [SerializeField] DT_PlayerInput InputsData;
    [SerializeField] DT_PlayerMovement MovementStats;

    public KeyCode[] getHorizontalMovementInput()
    {
        return InputsData.getHorzInputs();
    }

    public float[] getHorizontalMovementStats()
    {
        return MovementStats.getHorizontalData();
    }

    public KeyCode getVerticalInput()
    {
        return InputsData.getVertInputs();
    }

    public float[] getVerticalStats()
    {
        return MovementStats.getVerticalData();
    }
}
