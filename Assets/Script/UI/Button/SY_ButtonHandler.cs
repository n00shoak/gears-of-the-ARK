using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ButtonHandler : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [Header("General")]
    public RectTransform rcTransform;

    [Header("hover effect")]
    public Image hoverFill;
    public float scaleBuff;
    public float scaleBuffSpeed;
    public float sliderSpeed;
    public AudioSource HoverEnterFX;
    public AudioSource HoverExitFX;

    [Header("on click")]
    public AudioSource clickFX;


    // >>> Hover effect <<<
    public void OnPointerEnter(PointerEventData eventData) // on hover enter
    {
        StopAllCoroutines();
        StartCoroutine(Resize(scaleBuff));
        StartCoroutine(fillIn(1.1f));

        if (HoverEnterFX != null)
            HoverEnterFX.Play();
    }


    public void OnPointerExit(PointerEventData eventData)
    {
        StopAllCoroutines();
        StartCoroutine(Resize(1));
        StartCoroutine(fillIn(-0.1f));

        if (HoverExitFX != null)
            HoverExitFX.Play();
    }

    //smooth up and down scale of the button
    public IEnumerator Resize(float target)
    {
        if (rcTransform.localScale.x <= target - 0.01f || rcTransform.localScale.x >= target + 0.01f)
        {
            rcTransform.localScale = Vector3.Lerp(rcTransform.localScale, new Vector3(target, target, target), 0.1f);
            yield return new WaitForSeconds(scaleBuffSpeed);
            StartCoroutine(Resize(target));
        }
        else
        {
        }
    }

    // smooth slider inside the button
    public IEnumerator fillIn(float target)
    {
        if (hoverFill.fillAmount <= target - 0.01f || hoverFill.fillAmount >= target + 0.01f)
        {
            hoverFill.fillAmount = Mathf.Lerp(hoverFill.fillAmount, target, sliderSpeed);
            yield return new WaitForSeconds(0.01f);
            StartCoroutine(fillIn(target));
        }
        else
            yield return null;
    }

    // >>> on click fx <<<
    public void fxSound()
    {
        if (clickFX != null)
            clickFX.Play();
    }
}
