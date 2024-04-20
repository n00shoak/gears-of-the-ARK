using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SY_AbillityProcedures : MonoBehaviour
{
    [SerializeField] public UnityEvent[] allprocedures;
    [SerializeField] private GameObject projectile;
    [SerializeField] private Rigidbody rb;
    [SerializeField] private Transform orientation;

    private void Awake()
    {
        rb = GetComponentInParent<Rigidbody>();
    }

    public void print()
    {
        Debug.Log("OUI");
    }

    public void HitScanShoot()
    {
        Debug.DrawLine(transform.position, transform.position + orientation.forward * 20f, Color.blue);
        if (Physics.Raycast(transform.position,transform.right,20f))
        {
            Debug.Log("PIOUUU");
        }
    }

    public void ProjectileShoot()
    {
        GameObject bullet = Instantiate(projectile, transform.position,orientation.rotation);
        bullet.transform.parent = null;
    }

    public void Dash()
    {
        StartCoroutine(Dashing());
    }

    private IEnumerator Dashing()
    {
        MN_GeneralManager.GetManagerfromGeneral<MN_PlayerMovement>().enabled = false;
        Vector3 initVel = rb.velocity;
        rb.velocity = new Vector3(rb.velocity.x,0, rb.velocity.z).normalized * 50;
        yield return new WaitForSeconds(0.2f);
        rb.velocity = initVel;
        MN_GeneralManager.GetManagerfromGeneral<MN_PlayerMovement>().enabled = true;

    }
}
