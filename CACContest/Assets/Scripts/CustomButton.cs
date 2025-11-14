using UnityEngine;
using UnityEngine.EventSystems;

public class CustomButton : MonoBehaviour,
    IPointerClickHandler,
    IPointerDownHandler,
    IPointerUpHandler
{
    // ボタンをクリックした時
    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("Button Clicked");
    }

    // ボタンを押している間
    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("Button Pressed");
    }

    // ボタンを離したとき
    public void OnPointerUp(PointerEventData eventData)
    {
        Debug.Log("Button Released");
    }
}
