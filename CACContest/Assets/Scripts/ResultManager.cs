using UnityEngine;
using TMPro;

public class ResultManager : MonoBehaviour
{
    public Apple appleData;
    public TextMeshProUGUI resultText;
    public TextMeshProUGUI resultPointText;
    void Start()
    {
        resultText.text = "Result";
        resultPointText.text = appleData.score.ToString();
    }
}
