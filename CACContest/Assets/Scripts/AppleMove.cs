using Unity.VisualScripting;
using UnityEngine;

public class AppleMove : MonoBehaviour
{
    public Apple appleData;
    private bool isInFrame = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(appleData.moveSpeed * Time.deltaTime, 0, 0);
        if (transform.localPosition.x <= appleData.destroyPos.x)
        {
            appleData.appleName = "";
            appleData.isPushed = false;
            appleData.score--;
            Debug.Log("スコア: " + appleData.score);
            Destroy(this.gameObject);
        }
        else if (appleData.isPushed)
        {
            appleData.isPushed = false;
            appleData.appleName = "";
            Destroy(this.gameObject);
        }

        // 枠内判定
        if (!isInFrame && transform.localPosition.x <= -250f && transform.localPosition.x >= -350f)
        {
            isInFrame = true;
            appleData.appleName = this.name;
        }
        if (isInFrame && transform.localPosition.x <= -350f)
        {
            isInFrame = false;
            appleData.appleName = "";
        }
    }
}
