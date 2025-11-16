using UnityEngine;
using TMPro;

public class ResultManager : MonoBehaviour
{
    public Apple appleData;
    public TextMeshProUGUI resultText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        resultText.text = "Result\n" + appleData.result.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
