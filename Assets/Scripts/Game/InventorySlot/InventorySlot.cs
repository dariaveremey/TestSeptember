using Game.Item;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Game.InventorySlot
{
    public class InventorySlot : MonoBehaviour, IDropHandler
    {
        public void OnDrop(PointerEventData eventData)
        {
            if (transform.childCount != 0)
                return;
            GameObject dropped = eventData.pointerDrag;
            DraggableItem draggableItem = dropped.GetComponent<DraggableItem>();
            draggableItem._parenAfterDrag = transform;
        }
    }
}