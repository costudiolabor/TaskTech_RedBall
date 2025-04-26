using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonCustom : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler {

    public event Action<bool> ButtonClick; 

    public void OnPointerEnter(PointerEventData eventData) { ButtonClick?.Invoke(true); }

    public void OnPointerExit(PointerEventData eventData) { ButtonClick?.Invoke(false); }
}
