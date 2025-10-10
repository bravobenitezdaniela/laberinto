using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//biblioteca ui
using UnityEngine.Audio; //biblioteca audio 


    public class AudioController : MonoBehaviour
{
    public bool musicMute;
    public bool soundMute;
    public bool mastermute;
    public AudioMixer audioMixer;
    public float previousSound=0;
    public float previousMusic=0;
    public float previousMaster=0;
void Start ()
    
    {
        audioMixer = Resources.Load<AudioMixer>("MainMixed");
    }
public float GetLevel(string bus)
    {
        float value;
        bool result= audioMixer.GetFloat(bus, out value);
        if (result)
        {
            return value;
        }
        else
        {
            return 0f;
        }
    }
public void MasterVolume(Slider volume )
    {
        audioMixer.SetFloat("Master", volume.value); 
    }
public void MusicVolume(Slider volume )
    {
        audioMixer.SetFloat("Musica", volume.value); 
    }
public void SoundVolume(Slider volume )
    {
        audioMixer.SetFloat("Sonidos", volume.value); 
    }
public void SoundMute()
    {
    
    if (soundMute){
        audioMixer.SetFloat("Sonidos", previousSound);
    }

    else{
        soundMute= true;
        previousSound = GetLevel ("Sonidos");
        audioMixer.SetFloat("Sonidos" , -80);

    }
    
    }
}


    
