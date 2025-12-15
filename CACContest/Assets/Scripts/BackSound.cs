using UnityEngine;

public class BackSound : MonoBehaviour
{
    public AudioSource buttonSound;
    public AudioSource hoverSound;
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
            buttonSound.Play();
            isPlayed = false;
        }
    }
}
