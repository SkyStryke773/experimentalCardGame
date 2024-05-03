using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using static Drag;
using static UnityEngine.Rendering.DebugUI;

public class DropZone : MonoBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler
{
    public Drag.Slot typeOfCard = Drag.Slot.HAND;


    public void  OnPointerEnter(PointerEventData eventData)
    {
        

   
    if (eventData.pointerDrag == null)
    {
        return;
    }
    Drag d = eventData.pointerDrag.GetComponent<Drag>();
    if (d != null )
    {
        d.placeholderParent = this.transform;
    }

    }
    public void OnPointerExit(PointerEventData eventData)
    {
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
        Drag d = eventData.pointerDrag.GetComponent<Drag>();

        Transform droppedCard = d.parentToReturnTo;
        Transform panelBelow = GetComponent<Transform>();    

        Debug.Log("on drop to" + gameObject.name);


        
        if (d != null)
        {
            if (typeOfCard == Slot.BOARD)
            {
                d.parentToReturnTo = this.transform;

            }
            if (typeOfCard == Slot.ATTACK && panelBelow.transform.GetChild(0) != null)
            {
                for (int i = 0; i < panelBelow.transform.childCount; i++)
                {
                    panelBelow.transform.GetChild(i).SetParent(droppedCard);
                }
                d.parentToReturnTo = this.transform;

                //Swaps card from attack to board
                
                

            } 


        }
        
    }
     
}
