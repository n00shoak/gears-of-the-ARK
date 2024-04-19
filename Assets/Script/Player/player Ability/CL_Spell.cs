using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(fileName = "Spell", menuName = "Spell", order = 0)]
public class CL_Spell : ScriptableObject
{
    [SerializeField] private float cooldown,castTime,Stack,cost;
    [SerializeField] DT_SpellType.spellType type;
    public int selectedProcedure;
    public UnityEvent procedure;
}
