using UnityEngine;

public class AudioController : MonoBehaviour

{

    public static AudioController instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    
    public void PlayAudioClip(AudioClip sound, bool loop)
    {
        soundSource.clip = sound;
        soundSource.loop = loop;
        soundSource.Play();
    }
    
    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
