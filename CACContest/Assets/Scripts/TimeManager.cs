using UnityEngine;
using TMPro;
using System.Collections;

public class TimeManager : MonoBehaviour
{
    public Apple appleData;
    public TextMeshProUGUI timeText;
    public TextMeshProUGUI timeUpText;
    public AudioSource endSound;
    public AppleButton appleButton;
    public GoldAppleButton goldAppleButton;
    public PoisonAppleButton poisonAppleButton;
    private bool isTimeUp = false;
    private bool isTimePlus = false;
    private bool intervalDecreased = false;
    private int highScore = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // 初期化処理
        Initialize();
        timeUpText.gameObject.SetActive(false);
        isTimeUp = false;
    }

    // Update is called once per frame
    void Update()
    {
        timeText.text = "Time\n" + Mathf.FloorToInt(appleData.timeLimit).ToString();
        TimeUp();
        // 出現速度増加
        if (appleData.score % 10 == 0 && appleData.score > 0 && !intervalDecreased && appleData.interval > 1.0f)
        {
            appleData.interval -= 0.2f;
            intervalDecreased = true;
        }
        else if (appleData.score % 10 != 0)
        {
            intervalDecreased = false;
        }

        // 移動速度増加＆制限時間延長
        if (appleData.score % 5 == 0 && appleData.score > highScore && !isTimePlus)
        {
            appleData.timeLimit += 5f;
            appleData.moveSpeed -= 50f;
            isTimePlus = true;
            highScore = appleData.score;
            Debug.Log(appleData.score + " " + highScore);
        }
        else if (appleData.score % 5 != 0)
        {
            isTimePlus = false;
        }
    }

    void Initialize()
    {
        // スコア初期化
        appleData.score = 0;
        appleData.isPushed = false;
        appleData.appleName = "";
        appleData.timeLimit = 30f;
        appleData.interval = 1.6f;
        appleData.moveSpeed = -600f;
        appleData.life = 3;
        highScore = 0;
    }

    // タイムアップ処理
    public void TimeUp()
    {
        if ((appleData.timeLimit <= 0 || appleData.life <= 0) && !isTimeUp)
        {
            // ゲーム終了でボタンを押せなくする
            appleButton.enabled = false;
            goldAppleButton.enabled = false;
            poisonAppleButton.enabled = false;
            
            appleData.timeLimit = 0;
            timeUpText.gameObject.SetActive(true);
            isTimeUp = true;
            appleData.result = appleData.score;
            endSound.Play();
            StartCoroutine(LoadResult());
        }
        else if (!isTimeUp)
        {
            appleData.timeLimit -= Time.deltaTime;
        }
    }

    // リザルト画面へ遷移するためのコルーチン
    private IEnumerator LoadResult()
    {
        yield return new WaitForSeconds(3f);
        Initiate.Fade("Result", Color.black, 2f);
    }
}
