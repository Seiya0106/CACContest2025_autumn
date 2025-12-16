using UnityEngine;
using TMPro;

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
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
