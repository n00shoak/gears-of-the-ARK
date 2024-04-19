using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SY_AbillityProcedures : MonoBehaviour
{
    [SerializeField] public UnityEvent[] allprocedures;

    private void Awake()
    {
    
    }

    public void print()
    {
        Debug.Log("OUI");
    }

    public void HitScanShoot()
    {
        Debug.DrawLine(transform.position, transform.position + transform.right * 20f, Color.blue);
        if (Physics.Raycast(transform.position,transform.right,20f))
        {
            Debug.Log("PIOUUU");
        }
    }
}
