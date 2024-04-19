using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DT_PlayerInput : MonoBehaviour
{
    [SerializeField] private KeyCode moveForward = KeyCode.W, moveBackward = KeyCode.S;
    [SerializeField] private KeyCode moveLeft = KeyCode.A, moveRight = KeyCode.D;
    [SerializeField] private KeyCode sprint = KeyCode.LeftShift;
    [SerializeField] private KeyCode dodge = KeyCode.LeftAlt;
    [SerializeField] private KeyCode Jump = KeyCode.Space;
    [SerializeField] private KeyCode SP_Primary = KeyCode.Mouse0, SP_Secondary = KeyCode.Mouse1, SP_Utility = KeyCode.Q, SP_Ultimate = KeyCode.R;
    [SerializeField] private KeyCode changeCamView = KeyCode.V, freeCam = KeyCode.B;

    public KeyCode[] getHorzInputs()
    {
        KeyCode[] keys = new KeyCode[]
        {
            moveForward, moveBackward, 
            moveLeft, moveRight,
        };
        return keys;
    }

    public KeyCode getVertInputs()
    {
        return Jump;
    }
}
