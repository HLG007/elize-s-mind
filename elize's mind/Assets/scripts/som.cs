using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Audio;

public class som : MonoBehaviour
{
    [SerializeField] private AudioMixer myAudiomixer;

    public void SetVolume(float slidervalue)
    {
        myAudiomixer.SetFloat("MasterVolume", Mathf.Log10(slidervalue) * 20);
        Debug.Log(slidervalue);
    }
}
