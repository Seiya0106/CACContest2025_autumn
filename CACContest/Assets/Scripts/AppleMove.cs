using UnityEngine;

public class AppleMove : MonoBehaviour
{
    public Apple appleData;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(appleData.moveSpeed * Time.deltaTime * 500f, 0, 0);
        if (transform.localPosition.x <= appleData.destroyPos.x)
        {
            Destroy(this.gameObject);
        }
    }
}
