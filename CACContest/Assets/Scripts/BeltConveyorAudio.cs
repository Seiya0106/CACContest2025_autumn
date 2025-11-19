using UnityEngine;

public class BeltConveyorAudio : MonoBehaviour
{
    public Apple appleData;
    public AudioSource conveyorSound;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (appleData.timeLimit > 0)
        {
            conveyorSound.Play();
        }
        else
        {
            conveyorSound.Stop();
        }
    }
}
