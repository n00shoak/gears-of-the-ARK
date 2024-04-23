using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class SY_SwitchMenu : MonoBehaviour
{
    [SerializeField] private Image transitionSlide;
    [SerializeField] private GameObject cam;

    public void startTransition(float target)
    {
        StartCoroutine(transition(target));
    }


    private IEnumerator transition(float targetPos)
    {
        transitionSlide.fillOrigin = 0;
        StartCoroutine(slideIN());

        yield return new WaitForSeconds(1f);
        cam.transform.position = new Vector3(targetPos, 0, 0);
        yield return new WaitForSeconds(1f);

        transitionSlide.fillOrigin = 1;
        StartCoroutine(slideOUT());
    }


    private IEnumerator slideIN()
    {
        transitionSlide.fillAmount = Mathf.Lerp(0, 1, 0.01f);
        yield return new WaitForSeconds(0);
        if(!(transitionSlide.fillAmount > 0.95f))
        {
            StartCoroutine(slideIN());
        }
    }

    private IEnumerator slideOUT()
    {
        transitionSlide.fillAmount = Mathf.Lerp(1, 0, 0.01f);
        yield return new WaitForSeconds(0);
        if (!(transitionSlide.fillAmount < 0.05f))
        {
            StartCoroutine(slideOUT());
        }
    }
}
