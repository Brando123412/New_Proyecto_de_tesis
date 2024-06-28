using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using TMPro;

[CreateAssetMenu(fileName = "ChannelManager", menuName = "ScriptableObjects/ChannelManager", order = 1)]
public class ChannelManager : ScriptableObject
{
    [SerializeField] string channelVolume;
    public float currentVolume;
    [SerializeField] private AudioMixer myMixer;
    public float valueVolume;
    bool startconfirmation;
    public void UpdateVolume(Slider mySlider)
    {
        if (startconfirmation != true)
        {
            currentVolume = mySlider.value;
            myMixer.SetFloat(channelVolume, Mathf.Log10(currentVolume) * 20f);
        }
        else
        {
            startconfirmation = false;
        }
    }

    public void Inicio(bool prueba)
    {
        startconfirmation = prueba;
    }
}