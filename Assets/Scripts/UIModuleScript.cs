using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class UIModuleScript : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler, IPointerDownHandler, IPointerUpHandler
{
	void Start()
    {
	
	}
	
	void Update()
    {
	
	}

    void IPointerEnterHandler.OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log(gameObject.name + "Enter");
        gameObject.GetComponent<Image>().color = Color.blue;
        
    }

    void IPointerExitHandler.OnPointerExit(PointerEventData eventData)
    {
        Debug.Log(gameObject.name + "Exit");
        gameObject.GetComponent<Image>().color = Color.white;
    }

    void IPointerClickHandler.OnPointerClick(PointerEventData eventData)
    {

    }

    void IPointerDownHandler.OnPointerDown(PointerEventData eventData)
    {
        if (eventData.button == 0)
        Debug.Log(eventData.button);
    }

    void IPointerUpHandler.OnPointerUp(PointerEventData eventData)
    {

    }
}
