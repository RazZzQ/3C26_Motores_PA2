using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;


[CreateAssetMenu(fileName = "SO_AudioManager", menuName = "ScriptableObjects/AudioManager", order = 1)]
public class SO_AudioManager : ScriptableObject
{
    public AudioMixer Mixer;
    public AudioMixerGroup group;
    public string AudioParameter;
    public void mutechannel()
    {
        Mixer.SetFloat(AudioParameter, -80f);
    }
    public void unmutechannel()
    {
        Mixer.SetFloat(AudioParameter, 0f);
    }
    public void getvolume(ref float volume)
    {
        Mixer.GetFloat(AudioParameter, out volume);
    }
    public void UpdateVolumen(float newvolume)
    {
        Debug.Log("algo");
        newvolume = Mathf.Log10(newvolume) * 20f;
        Mixer.SetFloat(AudioParameter, newvolume);
    }
}
