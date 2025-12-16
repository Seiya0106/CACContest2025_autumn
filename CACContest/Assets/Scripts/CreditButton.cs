using UnityEngine;
using UnityEngine.EventSystems;
using DG.Tweening;

public class CreditButton : MonoBehaviour,
    IPointerClickHandler,
    IPointerDownHandler,
    IPointerUpHandler,
    IPointerEnterHandler,
    IPointerExitHandler
{
    public System.Action onClickCallback;
    public GameObject creditPanel;
    public AudioSource buttonSound;
    public AudioSource hoverSound;

    [SerializeField] private CanvasGroup canvasGroup;
    // ボタンをクリックした時
    public void OnPointerClick(PointerEventData eventData)
    {
        onClickCallback?.Invoke();
    }

    // ボタンを押している間
    public void OnPointerDown(PointerEventData eventData)
    {
        transform.DOScale(0.95f, 0.15f).SetEase(Ease.OutCubic);
        canvasGroup.DOFade(0.8f, 0.15f).SetEase(Ease.OutCubic); 
    }

    // ボタンを離したとき
    public void OnPointerUp(PointerEventData eventData)
    {
        transform.DOScale(1f, 0.24f).SetEase(Ease.OutCubic);  
        canvasGroup.DOFade(1f, 0.24f).SetEase(Ease.OutCubic);
        buttonSound.Play();
        creditPanel.SetActive(true);
    }
    // hover時
    public void OnPointerEnter(PointerEventData eventData)
    {
        transform.DOScale(1.03f, 0.24f).SetEase(Ease.OutCubic);
        hoverSound.Play();
    }
    // hover終了時
    public void OnPointerExit(PointerEventData eventData)
    {
        transform.DOScale(1f, 0.24f).SetEase(Ease.OutCubic);
    }
}
