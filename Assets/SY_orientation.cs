using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SY_orientation : MonoBehaviour
{
    [SerializeField] private Transform camPos,playerPos;



    private void Update()
    {
        transform.rotation = Quaternion.Euler( camPos.eulerAngles.z, camPos.eulerAngles.y +90 , camPos.eulerAngles.x);
    }

}
