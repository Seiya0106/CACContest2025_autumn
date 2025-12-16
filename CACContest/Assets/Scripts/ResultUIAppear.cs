using UnityEngine;
using DG.Tweening;

public class ResultUIAppear : MonoBehaviour
{
    [SerializeField] private RectTransform result;
    [SerializeField] private RectTransform point;
    [SerializeField] private RectTransform backTitle;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        result = result.GetComponent<RectTransform>();
        point = point.GetComponent<RectTransform>();
        backTitle = backTitle.GetComponent<RectTransform>();
        result.anchoredPosition = new Vector2(result.anchoredPosition.x + 600f, result.anchoredPosition.y);
        point.anchoredPosition = new Vector2(point.anchoredPosition.x + 600f, point.anchoredPosition.y);
        backTitle.anchoredPosition = new Vector2(backTitle.anchoredPosition.x + 600f, backTitle.anchoredPosition.y);
        result.gameObject.SetActive(false);
        point.gameObject.SetActive(false);
        backTitle.gameObject.SetActive(false);
        result.gameObject.SetActive(true);
        result.DOAnchorPosX(-600f, 2.0f).SetEase(Ease.OutCubic).SetRelative(true);
        point.gameObject.SetActive(true);
        point.DOAnchorPosX(-600f, 2.0f).SetEase(Ease.OutCubic).SetRelative(true).SetDelay(0.5f);
        backTitle.gameObject.SetActive(true);
        backTitle.DOAnchorPosX(-600f, 2.0f).SetEase(Ease.OutCubic).SetRelative(true).SetDelay(1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
