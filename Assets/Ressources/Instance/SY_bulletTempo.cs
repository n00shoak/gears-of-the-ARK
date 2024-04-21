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
        if(collision.gameObject.layer == gameObject.layer)
        {
            Debug.Log("projectileTouched");
            iaTEUBE ennemisTOUCHED = collision.gameObject.GetComponent<iaTEUBE>();
            if(ennemisTOUCHED != null) 
            { 
                ennemisTOUCHED.Stun();
                Rigidbody foeRB = collision.gameObject.GetComponent<Rigidbody>();
                foeRB.velocity = rb.velocity.normalized * 60f;
            }

            Destroy(gameObject);
        }

    }
}
