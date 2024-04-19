using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MN_PlayerMovement))]
public class SY_groundCheck : MonoBehaviour
{
    [SerializeField] private float groundDist;
    [SerializeField] private LayerMask playerLayer;
    public bool grounded;

    public void M_Update()
    {
        grounded = Physics.Raycast(transform.position, Vector3.down , groundDist , ~playerLayer);

    }

    private void OnDrawGizmos()
    {
        Debug.DrawLine(transform.position, transform.position + Vector3.down * groundDist,Color.red);
    }
}
