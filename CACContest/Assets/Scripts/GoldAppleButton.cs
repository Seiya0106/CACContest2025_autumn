using UnityEngine;
using UnityEngine.EventSystems;
using DG.Tweening;

public class GoldAppleButton : MonoBehaviour,
    IPointerClickHandler,
    IPointerDownHandler,
    IPointerUpHandler
{
    public System.Action onClickCallback;
    public Apple appleData;
    public LifeManager lifeManager;
    public AudioSource correctSound;
    public AudioSource normalSound;
    public AudioSource wrongSound;

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
        if (appleData.appleName == "GoldApple(Clone)")
        {
            Debug.Log("金のリンゴが押された");
            appleData.score++;
            Debug.Log("スコア: " + appleData.score);
            appleData.isPushed = true;
            correctSound.Play();
        }
        else if (appleData.appleName == "")
        {
            Debug.Log("枠内にりんごがありません");
            normalSound.Play();
        }
        else
        {
            Debug.Log("違うリンゴが押された");
            appleData.life--;
            Debug.Log("スコア: " + appleData.score);
            appleData.isPushed = true;
            wrongSound.Play();
            lifeManager.isLifeChanged = true;
        }
    }
}
