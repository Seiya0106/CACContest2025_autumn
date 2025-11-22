using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class LifeManager : MonoBehaviour
{
    public Apple appleData;
    public List<Image> lifeImages;
    public bool isLifeChanged = false;
    private int lifeCount;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        lifeCount = appleData.life;
    }

    // Update is called once per frame
    void Update()
    {
        if (isLifeChanged)
        {
            lifeCount--;
            lifeImages[lifeCount].gameObject.SetActive(false);
            isLifeChanged = false;
        }
    }
}
