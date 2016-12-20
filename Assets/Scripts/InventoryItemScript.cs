using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class InventoryItemScript : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    enum ItemState { itemStationary, itemDrag }
    ItemState itemState;

    Vector3 offset;

	void Start()
    {
	
	}
	
	void Update()
    {
        switch (itemState)
        {
            case ItemState.itemDrag:
                gameObject.transform.position = Input.mousePosition + offset;
                Debug.Log("(Make invisible yo)");
                Cursor.visible = false;
                break;
            case ItemState.itemStationary:
                Debug.Log("(Make visible yo)");
                Cursor.visible = true;
                break;
        }

        if(itemState == ItemState.itemDrag)
        {
            gameObject.transform.position = Input.mousePosition + offset;
            Debug.Log("(Make invisible yo)");
            Cursor.visible = false;
        }
        else
        {
            Debug.Log("(Make visible yo)");
            Cursor.visible = true;
        }

    }

    void IPointerDownHandler.OnPointerDown(PointerEventData eventData)
    {
        offset = gameObject.transform.position - Input.mousePosition;
        Debug.Log("Set to DOWN");
        itemState = ItemState.itemDrag;
    }

    void IPointerUpHandler.OnPointerUp(PointerEventData eventData)
    {
        Debug.Log("set to UP");
        itemState = ItemState.itemStationary;
    }
}
