using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance;

    public AudioSource bgMusicSource;
    public AudioSource sfxSource;

    public AudioClip bgMusic;
    public AudioClip hitPaddleSFX;
    public AudioClip gameOverSFX;
    public AudioClip gameStartSFX;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        PlayBGMusic();
    }

    public void PlayBGMusic()
    {
        if (bgMusicSource != null && bgMusic != null)
        {
            bgMusicSource.clip = bgMusic;
            bgMusicSource.loop = true;
            bgMusicSource.Play();
        }
    }

    public void PlayHitPaddleSFX()
    {
        if (sfxSource != null && hitPaddleSFX != null)
        {
            sfxSource.PlayOneShot(hitPaddleSFX);
        }
    }

    public void PlayGameOverSFX()
    {
        if (sfxSource != null && gameOverSFX != null)
        {
            sfxSource.PlayOneShot(gameOverSFX);
        }
    }

    public void PlayGameStartSFX()
    {
        if (sfxSource != null && gameStartSFX != null)
        {
            sfxSource.PlayOneShot(gameStartSFX);
        }
    }
}
