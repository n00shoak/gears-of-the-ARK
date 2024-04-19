using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

/// <summary>
/// contain all existing spells 
/// </summary>
public class SY_SpellStorage : MonoBehaviour
{
    public CL_Spell[] existingSpells;
    [SerializeField]private SY_AbillityProcedures procedures;

    private void Awake()
    {
        Debug.Log(existingSpells.Length);

        for(int i = 0; i < existingSpells.Length; i++)
        {
            existingSpells[i].procedure = procedures.allprocedures[existingSpells[i].selectedProcedure];
        }
    }
}
