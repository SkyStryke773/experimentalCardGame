using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using static Drag;

public class DropZone : MonoBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler
{
    public Drag.Slot typeOfCard = Drag.Slot.HAND;
    public void  OnPointerEnter(PointerEventData eventData)
    {
        

    Debug.Log("on pointer enter ");
    if (eventData.pointerDrag == null)
    {
        return;
    }
    Drag d = eventData.pointerDrag.GetComponent<Drag>();
    if (d != null)
    {
        d.placeholderParent = this.transform;
    }

    }
    public void OnPointerExit(PointerEventData eventData)
    {
        Debug.Log("on pointer exit ");
        if (eventData.pointerDrag == null)
        {
            return;
        }

        Drag d = eventData.pointerDrag.GetComponent<Drag>();
        if (d != null && d.placeholderParent == this.transform)
        {
            d.placeholderParent = d.parentToReturnTo;
        }
    }
    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("on drop to" + gameObject.name);

        Drag d = eventData.pointerDrag.GetComponent<Drag>();
        if (d != null)
        {
            if(typeOfCard == d.typeOfCard)
            {
                d.parentToReturnTo = this.transform;
            }
            
        }
    }
     
}
