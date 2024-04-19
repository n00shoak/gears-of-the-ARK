using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MN_PlayerMovement))]
public class SY_VerticalMovement : MonoBehaviour
{
    [SerializeField] private int jumpAmmount = 1,jumpLeft;
    [SerializeField] private float[] stats;
    [SerializeField] private KeyCode jumpKey;

    [SerializeField] private SY_groundCheck checkGround;
    public Vector3 veritcallVelocity;

    public void setData(KeyCode _jumpKey,float[] _stats, int jump)
    {
        jumpKey = _jumpKey;
        stats = _stats;
        jumpAmmount = jump;
    }

    public void M_Update()
    {
        if(!checkGround.grounded) 
        {
            veritcallVelocity += Vector3.down * stats[0];
        }
        else if(veritcallVelocity.y < 0) 
        {
            jumpLeft = jumpAmmount;
            veritcallVelocity = Vector3.zero;
        }

        if(Input.GetKeyDown(jumpKey) && jumpLeft > 0)
        {
            jumpLeft--;
            veritcallVelocity = Vector3.up * stats[1];
        }
    }
}
