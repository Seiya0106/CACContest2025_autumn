using UnityEngine;
using UnityEngine.EventSystems;
using DG.Tweening;

public class PreviousButton : MonoBehaviour,
    IPointerClickHandler,
    IPointerDownHandler,
    IPointerUpHandler
{
    public System.Action onClickCallback;
    public GameObject thisPanel;
    public GameObject previousPanel;
    public AudioSource buttonSound;
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
        buttonSound.Play();
        thisPanel.SetActive(false);
        previousPanel.SetActive(true);
    }
}
