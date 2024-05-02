using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.XR;

public class Drag : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
   
      
     public Transform parentToReturnTo = null;

    public void OnBeginDrag(PointerEventData eventData)
    {
        parentToReturnTo = this.transform.parent;
        //Debug.Log(parentToReturnHome);


        //Issue Below, card does not to leave parent "hand"
        this.transform.SetParent(this.transform.parent.parent);
        //Debug.Log("begin.................................................");

        //Debug.Log(parentToReturnHome);
        GetComponent<CanvasGroup>().blocksRaycasts = false;


    }
    public void OnDrag(PointerEventData eventData)
    {
        this.transform.position = eventData.position;
       // Debug.Log("dragging");
    }
    public void OnEndDrag(PointerEventData eventData)
    {
        this.transform.SetParent(parentToReturnTo);
       // Debug.Log("ended.................................................");

        //also error but fixes issue temperaRILY
        //this.transform.SetParent(transform.Find("Canvas"));

        GetComponent<CanvasGroup>().blocksRaycasts = true;


    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
