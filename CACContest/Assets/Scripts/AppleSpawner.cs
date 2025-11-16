using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AppleSpawner : MonoBehaviour
{
    public Apple appleData;
    void Start()
    {
        // スコア初期化
        appleData.score = 0;
        appleData.isPushed = false;
        appleData.appleName = "";
        
        StartCoroutine(SpawnApple());
    }

    void Update()
    {
        
    }

    private IEnumerator SpawnApple()
    {
        while (true)
        {
            yield return new WaitForSeconds(appleData.interval);
            int index = Random.Range(0, appleData.appleSprites.Count);
            // UI Image プレハブをインスタンス化し、この Transform（UI の親）に設定する
            // その後 RectTransform.anchoredPosition を設定して spawnPos に表示させる
            Image appleImage = Instantiate(appleData.appleSprites[index]);
            // world 位置を保持せずに親を設定（worldPositionStays = false）して、
            // ローカル座標／anchoredPosition が有効になるようにする
            appleImage.transform.SetParent(this.transform, false);
            // UI 配置には RectTransform.anchoredPosition を使う
            appleImage.rectTransform.anchoredPosition = appleData.spawnPos;
        }
    }
}
