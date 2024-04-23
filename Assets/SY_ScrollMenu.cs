using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SY_ScrollMenu : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private float multiplier = 1f;

    public void Slide(float Index)
    {
        target.transform.position = new Vector3(target.transform.position.x, Index * multiplier, target.transform.position.z);
    }
}
