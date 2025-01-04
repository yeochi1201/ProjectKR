using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class UIEventHandler : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IPointerClickHandler
{
    public Action<PointerEventData> OnDownHandler = null;
    public Action<PointerEventData> OnUpHandler = null;
    public Action<PointerEventData> OnClickHandler = null;
    public void OnPointerDown(PointerEventData eventData)
    {
        OnDownHandler?.Invoke(eventData);
    }
    public void OnPointerUp(PointerEventData eventData)
    {
        OnUpHandler?.Invoke(eventData);
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        OnClickHandler?.Invoke(eventData);
    }
}
