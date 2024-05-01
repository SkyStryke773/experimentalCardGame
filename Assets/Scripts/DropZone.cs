using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropZone : MonoBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler
{
    public void onPointerEnter(PointerEventData eventData)
    {

    }

    public void onDrop(PointerEventData eventData)
    {
        debug.Log("dropped.................................................");
    }
   
    public void onPointerExit(PointerEventData eventData)
    {

    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
