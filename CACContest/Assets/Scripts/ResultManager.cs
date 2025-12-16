using UnityEngine;
using TMPro;
using unityroom.Api;

public class ResultManager : MonoBehaviour
{
    public Apple appleData;
    public TextMeshProUGUI resultText;
    public TextMeshProUGUI resultPointText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        resultText.text = "Result";
        resultPointText.text = appleData.score.ToString();
        UnityroomApiClient.Instance.SendScore(1, appleData.score, ScoreboardWriteMode.HighScoreDesc);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
