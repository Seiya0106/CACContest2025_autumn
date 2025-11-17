using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class LifeManager : MonoBehaviour
{
    public Apple appleData;
    public List<Image> lifeImages;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < appleData.life; i++)
        {
            lifeImages[i].gameObject.SetActive(true);
        }
        for (int i = appleData.life; i < lifeImages.Count; i++)
        {
            lifeImages[i].gameObject.SetActive(false);
        }
    }
}
