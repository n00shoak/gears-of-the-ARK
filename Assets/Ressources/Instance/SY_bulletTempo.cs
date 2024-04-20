using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SY_bulletTempo : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Start()
    {
        rb.velocity = transform.forward * 20f;
        StartCoroutine(lifeSpan());
    }

    IEnumerator lifeSpan()
    {
        yield return new WaitForSeconds(30);
        Destroy(gameObject);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("projectileTouched");
        Destroy(gameObject);
    }
}
