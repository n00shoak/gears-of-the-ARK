using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class S_Movable : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler
{

    private Vector3 startPos;
    private Transform endPos;

    public S_PieceManager manager;
    private CL_Spell spell;
    public int idSpell;
    public Image thisImage;

    public void OnBeginDrag(PointerEventData eventData)
    {
        //pourquoi je sais pas, mais ça marche pas sans
        thisImage.raycastTarget = false;
    }



    void IDragHandler.OnDrag(PointerEventData eventData)
    {
        transform.position = eventData.position;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        transform.position = startPos;
        thisImage.raycastTarget = true;
    }



    // Start is called before the first frame update
    void Start()
    {
        //getSpell
        spell = manager.spellList[idSpell];

        //getImageIcone(a recup dans le spell plus tard
        thisImage = GetComponent<Image>();

        //get pos image
        startPos = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
