using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class iaTEUBE : MonoBehaviour
{
    public Transform targetObject; // GameObject vers lequel vous voulez vous d�placer
    public float speed = 2f; // Vitesse � laquelle vous voulez vous d�placer
    bool sprint, sprinting;
    float personality;

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        personality = Random.Range(0.5f,2f);

    }

    private void FixedUpdate()
    {
        if (targetObject != null)
        {
            // Calculer la direction vers l'objet cible
            Vector3 direction = (targetObject.position - transform.position).normalized;
            if (direction.y > 1.5f) { direction = new Vector3(direction.x, 0, direction.z); }

            // Calculer la rotation pour regarder vers l'objet cible
            Quaternion lookRotation = Quaternion.LookRotation(direction);

            // Appliquer la rotation de mani�re fluide
            rb.MoveRotation(Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * 1));

            // Appliquer la v�locit� pour se d�placer vers l'objet cible � une vitesse constante
            rb.velocity = transform.forward * speed;
        }

        if (Random.Range(0, 500) <= 1) { sprint = true; }

        if (sprint)
        {
            Debug.Log(speed);
            StartCoroutine(RUN());
            sprint = false;
        }
    }

    IEnumerator RUN()
    {
        speed *= 3;
        yield return new WaitForSeconds(1.5f);
        speed = 2;
    }
}
