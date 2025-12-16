using UnityEngine;
using UnityEngine.EventSystems;
using DG.Tweening;
using UnityEngine.UI;

public class GoldAppleButton : MonoBehaviour,
    IPointerClickHandler,
    IPointerDownHandler,
    IPointerUpHandler,
    IPointerEnterHandler,
    IPointerExitHandler
{
    public System.Action onClickCallback;
    public Apple appleData;
    public GameButtonManager gameButtonManager;
    public LifeManager lifeManager;
    public AudioSource correctSound;
    public AudioSource normalSound;
    public AudioSource wrongSound;
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
        if (appleData.appleName == "GoldApple(Clone)")
        {
            appleData.score++;
            Debug.Log("スコア: " + appleData.score);
            appleData.isPushed = true;
            correctSound.Play();
        }
        else if (appleData.appleName == "")
        {
            normalSound.Play();
            gameButtonManager.isMissed = true;
        }
        else
        {
            appleData.life--;
            Debug.Log("スコア: " + appleData.score);
            appleData.isPushed = true;
            wrongSound.Play();
            lifeManager.isLifeChanged = true;
            gameButtonManager.isMissed = true;
        }

        if (gameButtonManager.isMissed)
        {
            this.GetComponent<Image>().color = gameButtonManager.color;
            this.enabled = false;
        }
    }
    // hover時
    public void OnPointerEnter(PointerEventData eventData)
    {
        transform.DOScale(1.05f, 0.24f).SetEase(Ease.OutCubic);
        hoverSound.Play();
    }
    // hover終了時
    public void OnPointerExit(PointerEventData eventData)
    {
        transform.DOScale(1f, 0.24f).SetEase(Ease.OutCubic);
    }
}
