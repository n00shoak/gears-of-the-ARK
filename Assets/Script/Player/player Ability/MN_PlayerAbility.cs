using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MN_PlayerAbility : CL_Manager
{
    [SerializeField] SY_useSpell useSpell;
    [SerializeField] Image[] SpellUI;

    private void Update()
    {
        SpellUI[0].fillAmount = Mathf.Lerp(SpellUI[0].fillAmount, useSpell.currentCoolDowns[0] / useSpell.coolDowns[0], Time.deltaTime * 20f);
        SpellUI[1].fillAmount = Mathf.Lerp(SpellUI[1].fillAmount, useSpell.currentCoolDowns[1] / useSpell.coolDowns[1], Time.deltaTime * 20f);
        SpellUI[2].fillAmount = Mathf.Lerp(SpellUI[2].fillAmount, useSpell.currentCoolDowns[2] / useSpell.coolDowns[2], Time.deltaTime * 20f);
        SpellUI[3].fillAmount = Mathf.Lerp(SpellUI[3].fillAmount, useSpell.currentCoolDowns[3] / useSpell.coolDowns[3], Time.deltaTime * 20f);
    }
}
