using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SY_useSpell : MonoBehaviour
{
    [SerializeField] private CL_Spell[] spells;
    [SerializeField] private SY_SpellStorage storage;
    [SerializeField] private ParticleSystem nozzle;
    [SerializeField] private ParticleSystem hitscanprt;


    [SerializeField] public float[] coolDowns;
    [SerializeField] public float[] currentCoolDowns;

    [SerializeField] private int[] stacks;
    [SerializeField] private int[] currentStacks;

    // time between two stacks
    [SerializeField] public float[] stacksCD;
    [SerializeField] public float[] currentStacksCD;




    private void Start()
    {
        spells = new CL_Spell[]
        {
            storage.existingSpells[0],
            storage.existingSpells[1],
            storage.existingSpells[2],
            storage.existingSpells[3],
        };

        coolDowns = new float[]{
            spells[0].cooldown,
            spells[1].cooldown,
            spells[2].cooldown,
            spells[3].cooldown,
        };

        stacks = new int[]
        {
            spells[0].Stack,
            spells[1].Stack,
            spells[2].Stack,
            spells[3].Stack,
        };

        stacksCD = new float[]{
            spells[0].stackCoolDown,
            spells[1].stackCoolDown,
            spells[2].stackCoolDown,
            spells[3].stackCoolDown,
        };

        currentCoolDowns = new float[4] { 0, 0, 0, 0 };
        currentStacks = new int[4] { 0, 0, 0, 0 };
        currentStacksCD = new float[4] { 0, 0, 0, 0 };

        StartCoroutine(SpellClocl());
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0) && currentStacks[0] >= 0 && currentStacksCD[0] <=0)
        {
            currentStacks[0] --;
            currentStacksCD[0] = stacksCD[0];
            spells[0].procedure.Invoke();
            nozzle.Play();
            hitscanprt.Play();
        }

        if (Input.GetKey(KeyCode.Mouse1) && currentStacks[1] >= 0 && currentStacksCD[1] <= 0)
        {
            Debug.Log("g mal au bras");
            currentStacks[1]--;
            currentStacksCD[1] = stacksCD[1];
            spells[1].procedure.Invoke();
            nozzle.Play();
        }

        if (Input.GetKey(KeyCode.LeftShift) && currentStacks[2] >= 0 && currentStacksCD[2] <= 0)
        {
            currentStacks[2]--;
            currentStacksCD[2] = stacksCD[2];
            spells[2].procedure.Invoke();
        }
    }

    private IEnumerator SpellClocl()
    {
        yield return new WaitForSeconds(0.1f);
        for(int i = 0; i < 4; i++)
        {
            if(currentStacks[i] < stacks[i])
            {
                if (currentCoolDowns[i] > 0)
                {
                    currentCoolDowns[i] -= 0.1f;
                }
                else
                {
                    currentCoolDowns[i] = coolDowns[i];
                    currentStacks[i] += 1;
                }
            }

            if (currentStacksCD[i] > 0)
            {
                currentStacksCD[i] -= 0.1f;
            }
        }
        StartCoroutine(SpellClocl());
    }
}
