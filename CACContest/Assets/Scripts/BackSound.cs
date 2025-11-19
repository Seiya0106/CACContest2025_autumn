using UnityEngine;

public class BackSound : MonoBehaviour
{
    public AudioSource backSound;
    public bool isPlayed = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isPlayed)
        {
            backSound.Play();
            isPlayed = false;
        }
    }
}
