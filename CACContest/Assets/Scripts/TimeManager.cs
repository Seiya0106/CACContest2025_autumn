using UnityEngine;
using TMPro;
using System.Collections;

public class TimeManager : MonoBehaviour
{
    public Apple appleData;
    public TextMeshProUGUI timeText;
    public TextMeshProUGUI timeUpText;
    private bool isTimeUp = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        timeUpText.gameObject.SetActive(false);
        isTimeUp = false;
    }

    // Update is called once per frame
    void Update()
    {
        timeText.text = "Time\n" + Mathf.FloorToInt(appleData.timeLimit).ToString();
        if (appleData.timeLimit <= 0 && !isTimeUp)
        {
            appleData.timeLimit = 0;
            timeUpText.gameObject.SetActive(true);
            isTimeUp = true;
            appleData.result = appleData.score;
            StartCoroutine(LoadResult());
        }
        else if (!isTimeUp)
        {
            appleData.timeLimit -= Time.deltaTime;
        }
    }

    private IEnumerator LoadResult()
    {
        yield return new WaitForSeconds(3f);
        Initiate.Fade("Result", Color.black, 2f);
    }
}
