using UnityEngine;
using DG.Tweening;

public class ResultUIAppear : MonoBehaviour
{
    [SerializeField] private RectTransform backTitle;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        backTitle = backTitle.GetComponent<RectTransform>();
        backTitle.anchoredPosition = new Vector2(backTitle.anchoredPosition.x + 600f, backTitle.anchoredPosition.y);
        backTitle.gameObject.SetActive(false);
        backTitle.gameObject.SetActive(true);
        backTitle.DOAnchorPosX(-600f, 2.0f).SetEase(Ease.OutCubic).SetRelative(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
