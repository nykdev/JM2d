using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragHandler : MonoBehaviour, IBeginDragHandler, IDragHandler , IEndDragHandler
{
   public static GameObject ItembeingDragged;
   private Vector3 _startPos;
   private Transform _startParent;

   public void OnBeginDrag(PointerEventData eventData)
   {
      ItembeingDragged = gameObject;
      _startPos = transform.position;
      _startParent = transform.parent;
     GetComponent<CanvasGroup>().blocksRaycasts = false;
   }

   public void OnDrag(PointerEventData eventData)
   {
      transform.position = Input.mousePosition;
   }

   public void OnEndDrag(PointerEventData eventData)
   {
      ItembeingDragged = null;
      GetComponent<CanvasGroup>().blocksRaycasts = true;
      if (transform.parent != _startParent)
      {
         transform.position = _startPos;

      }
   }
}
