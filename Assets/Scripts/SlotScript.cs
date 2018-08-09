using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SlotScript : MonoBehaviour,IDragHandler {

	public GameObject Item
	{
		get
		{
			if (transform.childCount > 0)
			{
				return transform.GetChild(0).gameObject;
			}

			return null;
		}
		
	}

	public void OnDrag(PointerEventData eventData)
	{
		if (!Item)
		{
			DragHandler.ItembeingDragged.transform.SetParent(transform);
		}
	}
}
