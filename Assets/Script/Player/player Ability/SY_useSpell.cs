using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SY_useSpell : MonoBehaviour
{
    [SerializeField] private CL_Spell[] spells;
    [SerializeField] private SY_SpellStorage storage;

    private void Start()
    {
        spells = new CL_Spell[]
        {
            storage.existingSpells[0]
        };  
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            spells[0].procedure.Invoke();
        }
    }
}
