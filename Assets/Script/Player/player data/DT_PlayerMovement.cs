using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DT_PlayerMovement : MonoBehaviour
{
    [SerializeField] private float maxSpeed, acceleration, friction;
    [SerializeField] private float strafeMultiplier;
    [SerializeField] private float Weight;
    [SerializeField] private float slideForce;

    [SerializeField] private float gravity;
    [SerializeField] private float jumpForce;
    [SerializeField] private int jumpAmmount;

    public float[] getHorizontalData()
    {
        float[] stats = new float[]
        {
            maxSpeed, acceleration, friction,
            strafeMultiplier,
            Weight, 
            slideForce,
        };
        return stats;
    }

    public float[] getVerticalData()
    {
        float[] stats = new float[]
        {
            gravity, jumpForce,jumpAmmount
        };
        return stats;
    }
}
