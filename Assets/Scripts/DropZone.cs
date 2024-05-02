using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropZone : MonoBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler
{
   public void  OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("on pointer enter ");
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        Debug.Log("on pointer exit ");
    }
    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("on drop to" + gameObject.name);

        Drag d = eventData.pointerDrag.GetComponent<Drag>();
        if (d != null)
        {
            d.parentToReturnTo = this.transform;
        }
    }
     
}
