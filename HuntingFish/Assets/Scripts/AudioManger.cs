using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManger : MonoBehaviour {

    private static AudioManger _instance;
    public static AudioManger Instance
    {
        get
        {
            return _instance;
        }
    }

    public AudioSource bgmAudioSource;
    public AudioClip seaWaveClip;
    public AudioClip goldClip;
    public AudioClip rewardClip;
    public AudioClip fireClip;
    public AudioClip changeClip;
    public AudioClip lvUpClip;
    private bool isMute = false;

    public bool IsMute
    {
        get
        {
            return isMute;
        }
    }

    void Awake()
    {
        _instance = this;
        isMute = (PlayerPrefs.GetInt("mute", 0) == 0) ? false : true;
        DoMute();
    }

    public void SwitchMuteState(bool isOn)
    {
        isMute = !isOn;
        DoMute();
    }

    public void DoMute()
    {
        if (isMute)
        {
            bgmAudioSource.Pause();
        }
        else
        {
            bgmAudioSource.Play();
        }
    }



    public void PlayEffectSound(AudioClip clip)
    {
        if (!isMute)
        {
            AudioSource.PlayClipAtPoint(clip, Vector3.zero);
        }
        
    }

}
