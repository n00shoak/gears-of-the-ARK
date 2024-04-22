using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class S_PartLinkUI : MonoBehaviour,IDropHandler
{

    public S_PlayerManager manager;
    private Image _image;

    public void OnDrop(PointerEventData eventData)
    {
        if(eventData.pointerDrag.gameObject.tag == "SpellArm")
        {
            S_Movable spellMoved = eventData.pointerDrag.GetComponent<S_Movable>();
            _image.color = spellMoved.thisImage.color;

        }


    }

    // Start is called before the first frame update
    void Start()
    {
        _image = GetComponent<Image>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
