using UnityEngine;
using TMPro;
using System.Collections;

public class ResultManager : MonoBehaviour
{
    public Apple appleData;
    public TextMeshProUGUI resultText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Color32 color = resultText.color;
        color.a = 0;
        resultText.color = color;
        resultText.text = "Result\n" + appleData.result.ToString();
        StartCoroutine(FadeInText());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private IEnumerator FadeInText()
    {
        Color color = resultText.color;
        while (color.a < 1.0f)
        {
            // 1秒でフェードイン
            color.a += Time.deltaTime;
            resultText.color = color;
            yield return null;
        }
    }
}
