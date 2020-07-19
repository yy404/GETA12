using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class AudioPlayer : MonoBehaviour
{
    public AudioClip clipFootstep;
    public AudioClip clipSuccess;
    public AudioClip clipFailure;
    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = clipFootstep;
        audioSource.Play();
        audioSource.Pause();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void PlayFootstep()
    {
        audioSource.UnPause();
    }

    public void StopPlay()
    {
        audioSource.Pause();
    }

    public void PlaySuccess()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(clipSuccess);
    }

    public void PlayFailure()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(clipFailure);
    }
}
