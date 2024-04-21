using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SY_Energy : MonoBehaviour
{
    [SerializeField] public float maxEnergy, currentEnergy,passifCharge;
    [SerializeField] private Slider energyBar;

    private void Start()
    {
        energyBar.maxValue = maxEnergy;
        StartCoroutine(energyClock());

    }

    IEnumerator energyClock()
    {
        if (currentEnergy < maxEnergy)
        {
            currentEnergy += passifCharge;
        }
        yield return new WaitForSeconds(0.5f);
        StartCoroutine(energyClock());
    }

    private void Update()
    {
        energyBar.value = Mathf.Lerp(energyBar.value, currentEnergy, Time.deltaTime * 25);
    }
}
