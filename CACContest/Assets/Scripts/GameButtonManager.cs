using UnityEngine;
using UnityEngine.UI;

public class GameButtonManager : MonoBehaviour
{
    public bool isMissed = false;
    [SerializeField] private float coolTime = 0.5f;
    public Color color = new Color(1f, 1f, 1f, 0.5f);
    public AppleButton appleButton;
    public GoldAppleButton goldAppleButton;
    public PoisonAppleButton poisonAppleButton;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        isMissed = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isMissed)
        {
            coolTime -= Time.deltaTime;
            if (coolTime <= 0f)
            {
                isMissed = false;
                coolTime = 0.3f;
                appleButton.GetComponent<Image>().color = Color.white;
                goldAppleButton.GetComponent<Image>().color = Color.white;
                poisonAppleButton.GetComponent<Image>().color = Color.white;
                appleButton.enabled = true;
                goldAppleButton.enabled = true;
                poisonAppleButton.enabled = true;
                Debug.Log("ResetMissed", gameObject);
            }
        }
    }
}
