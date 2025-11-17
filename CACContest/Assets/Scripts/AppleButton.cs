using UnityEngine;
using UnityEngine.EventSystems;
using DG.Tweening;
using UnityEngine.Analytics;

public class AppleButton : MonoBehaviour,
    IPointerClickHandler,
    IPointerDownHandler,
    IPointerUpHandler
{
    public System.Action onClickCallback;
    public Apple appleData;

    [SerializeField] private CanvasGroup canvasGroup;
    // ボタンをクリックした時
    public void OnPointerClick(PointerEventData eventData)
    {
        onClickCallback?.Invoke();
    }

    // ボタンを押している間
    public void OnPointerDown(PointerEventData eventData)
    {
        transform.DOScale(0.95f, 0.24f).SetEase(Ease.OutCubic);
        canvasGroup.DOFade(0.8f, 0.24f).SetEase(Ease.OutCubic); 
    }

    // ボタンを離したとき
    public void OnPointerUp(PointerEventData eventData)
    {
        transform.DOScale(1f, 0.24f).SetEase(Ease.OutCubic);  
        canvasGroup.DOFade(1f, 0.24f).SetEase(Ease.OutCubic);
        if (appleData.appleName == "Apple(Clone)")
        {
            Debug.Log("普通のリンゴが押された");
            appleData.score++;
            Debug.Log("スコア: " + appleData.score);
            appleData.isPushed = true;
        }
        else if (appleData.appleName == "")
        {
            Debug.Log("枠内にりんごがありません");
        }
        else
        {
            Debug.Log("違うリンゴが押された");
            appleData.life--;
            Debug.Log("スコア: " + appleData.score);
            appleData.isPushed = true;
        }
    }
}
