using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class SY_SwitchMenu : MonoBehaviour
{
    [SerializeField] private GameObject camTRF;
    [SerializeField] private GameObject transitionObject;
    [SerializeField] private Image ammount;
    [SerializeField] private float trsSpeed;
    bool waiting;

    private void Awake()
    {
        if (trsSpeed < 0 || trsSpeed > 1)
        {
            Debug.LogWarning("trsSpeed data is susless >> value under 0 or over 1");
        }
    }

    public void transition(float camPos)
    {
        Debug.Log("test A");
        transitionObject.SetActive(true);
        StartCoroutine(slide(camPos));
    }
    public IEnumerator slide(float cameraPos)
    {
        if (!waiting && ammount.fillAmount < 1)
        {
            Debug.Log("test C  " + ammount.fillAmount);
            ammount.fillAmount = Mathf.Lerp(ammount.fillAmount, 1.1f, trsSpeed);
            yield return new WaitForSeconds(0.01f);
            StartCoroutine(slide(cameraPos));
        }
        else if (!waiting)
        {
            camTRF.transform.position = new Vector3(cameraPos, camTRF.transform.position.y, camTRF.transform.position.z);
            yield return new WaitForSeconds(0.6f);
            ammount.fillOrigin = 1;
            waiting = true;
        }

        if (waiting && ammount.fillAmount > 0)
        {
            ammount.fillAmount = Mathf.Lerp(ammount.fillAmount, -0.1f, trsSpeed);
            yield return new WaitForSeconds(0.01f);
            StartCoroutine(slide(cameraPos));
        }
        else if (waiting)
        {
            ammount.fillOrigin = 0;
            transitionObject.SetActive(false);
            waiting = false;
            yield return null;
        }
    }
}
