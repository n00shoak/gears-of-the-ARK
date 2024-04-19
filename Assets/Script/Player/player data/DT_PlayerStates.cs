using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public static class DT_PlayerStates 
{
    public enum PlayerState
    {
        // movement states
        stunned,
        still,
        walk,
        run,
        dodging,

        // contact states
        air,
        grounded,

        // aggression states
        passif,
        attacking
    }
}
