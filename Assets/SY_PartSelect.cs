using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SY_PartSelect : MonoBehaviour
{
    [SerializeField] private bool[] selection;
    [SerializeField] private GameObject[] toShow;
    [SerializeField] private Scrollbar slider;

    public void Select(int index)
    {
        for(int i = 0; i < selection.Length; i++)
        {
            toShow[i].SetActive(false);
        }

        toShow[index].SetActive(true);

        slider.value = 0;
    }

}
