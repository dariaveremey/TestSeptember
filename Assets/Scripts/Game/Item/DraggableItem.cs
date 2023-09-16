﻿using UnityEngine;
using UnityEngine.EventSystems;

namespace Game.Item
{
    public class DraggableItem:MonoBehaviour,IBeginDragHandler,IDragHandler,IEndDragHandler
    {
        public void OnBeginDrag(PointerEventData eventData)
        {
            Debug.Log("Begin Drag");
        }

        public void OnDrag(PointerEventData eventData)
        {
            Debug.Log("Dragging");
        }

        public void OnEndDrag(PointerEventData eventData)
        {
            Debug.Log("End Drag");
        }
    }
}