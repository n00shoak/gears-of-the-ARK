using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(fileName = "Spell", menuName = "Spell", order = 0)]
public class CL_Spell : ScriptableObject
{
    [SerializeField] public float cooldown,castTime,cost,stackCoolDown;
    [SerializeField] public int Stack;
    [SerializeField] DT_SpellType.spellType type;
    public int selectedProcedure;
    public UnityEvent procedure;
}
