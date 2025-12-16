using UnityEngine;
using DG.Tweening;

public class TitelUIAppear : MonoBehaviour
{
    [SerializeField] private RectTransform credit;
    [SerializeField] private RectTransform rule;
    [SerializeField] private RectTransform start;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        credit = credit.GetComponent<RectTransform>();
        rule = rule.GetComponent<RectTransform>();
        start = start.GetComponent<RectTransform>();
        credit.anchoredPosition = new Vector2(credit.anchoredPosition.x + 400f, credit.anchoredPosition.y);
        rule.anchoredPosition = new Vector2(rule.anchoredPosition.x + 400f, rule.anchoredPosition.y);
        start.anchoredPosition = new Vector2(start.anchoredPosition.x + 400f, start.anchoredPosition.y);
        credit.gameObject.SetActive(false);
        rule.gameObject.SetActive(false);
        start.gameObject.SetActive(false);
        credit.gameObject.SetActive(true);
        credit.DOAnchorPosX(-400f, 1.0f).SetEase(Ease.OutCubic).SetRelative(true);
        rule.gameObject.SetActive(true);
        rule.DOAnchorPosX(-400f, 1.0f).SetEase(Ease.OutCubic).SetRelative(true).SetDelay(0.3f);
        start.gameObject.SetActive(true);
        start.DOAnchorPosX(-400f, 1.0f).SetEase(Ease.OutCubic).SetRelative(true).SetDelay(0.6f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
