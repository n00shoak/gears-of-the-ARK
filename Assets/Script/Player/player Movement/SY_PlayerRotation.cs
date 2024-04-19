using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SY_PlayerRotation : MonoBehaviour
{
    [SerializeField] private GameObject orientation;
    [SerializeField] private GameObject target;

    public void M_Update()
    {
       float targetAngle = orientation.transform.eulerAngles.y;
       target.transform.rotation = Quaternion.Euler(0, targetAngle - 90, 0);
    }
}
