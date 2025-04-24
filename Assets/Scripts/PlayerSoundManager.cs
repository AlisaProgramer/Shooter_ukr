using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSoundManager : MonoBehaviour
{
    private AudioSource audioSource;
    public AudioClip fire, jump, kick, reload;
    public static PlayerSoundManager Instance;
    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
        audioSource = gameObject.AddComponent<AudioSource>();

    }

   
    public void PlayFireSound()
    {
        audioSource.PlayOneShot(fire);
    }
    public void PlayReloadSound()
    {
        audioSource.PlayOneShot(reload);
    }
    public void PlayJumpSound()
    {
        audioSource.PlayOneShot(jump);
    }
    public void PlayKickSound()
    {
        audioSource.clip = kick;
        audioSource.Play();
    }
}
