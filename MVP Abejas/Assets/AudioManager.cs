using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    private static readonly string FirstPlay = "FirstPlay";
    private static readonly string SoundPref = "SoundPref";
    private static readonly string MusicPref = "MusicPref";
    private int firstPlayInt;
    public Slider musicSlider, soundSlider;
    private float musicFloat, soundFloat;
    public AudioSource musicAudio;
    public AudioSource[] soundAudio;

    // Start is called before the first frame update
    void Start()
    {
        firstPlayInt = PlayerPrefs.GetInt(FirstPlay);
        if (firstPlayInt == 0)
        {
            musicFloat = 0f;
            soundFloat = 0f;
            musicSlider.value = musicFloat;
            soundSlider.value = soundFloat;
            PlayerPrefs.SetFloat(SoundPref, soundFloat);
            PlayerPrefs.SetFloat(MusicPref, musicFloat);
            PlayerPrefs.SetInt(FirstPlay, -1);
        }
        else
        {
            soundFloat = PlayerPrefs.GetFloat(SoundPref);
            soundSlider.value = soundFloat;
            musicFloat = PlayerPrefs.GetFloat(MusicPref);
            musicSlider.value = musicFloat;
        }
    }
    public void Save()
    {
       // PlayerPrefs.SetFloat(SoundPref, soundFloat.value);
       // PlayerPrefs.SetFloat(MusicPref, musicFloat.value);
    }

    void OnApplicationFocus(bool inFocus)
    {
        if (!inFocus)
        {
            Save();
        }
    }

    public void UpdateSound()
    {
        musicAudio.volume = musicSlider.value;
        for(int i=0; i < soundAudio.Length; i++)
        {
            soundAudio[i].volume = soundSlider.value;

        }
    }
    
}
