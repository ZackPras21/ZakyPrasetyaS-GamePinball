using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    // kita masukan audio source bgm disini
    public AudioSource bgmAudioSource;

    // kita masukan game object sfx disini
    public GameObject sfxAudioSource;

    private void Start()
    {
        // jalankan BGM saat game dimulai
        PlayBGM();
    }

    public void PlayBGM()
    {
        // kita tinggal tambahkan saja fungsi untuk memainkan audio source bgm nya
        bgmAudioSource.Play();
    }

    public void PlaySFX(Vector3 spawnPosition)
    {
        GameObject.Instantiate(sfxAudioSource, spawnPosition, Quaternion.identity);
    }
}
