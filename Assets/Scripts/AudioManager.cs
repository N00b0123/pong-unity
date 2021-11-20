using System;
using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public static class AudioManager
{
    public enum Sound
    {
        Wall,
        Plataform,
        Win,
    }

    private static GameObject oneShotGameObject;
    private static AudioSource oneShotSource;

    public static void PlaySound(Sound sound)
    {
        if (oneShotGameObject == null)
        {
            oneShotGameObject = new GameObject("Sound");
            oneShotSource = oneShotGameObject.AddComponent<AudioSource>();
        }
        oneShotSource.PlayOneShot(GetAudioClip(sound));

    }

    private static AudioClip GetAudioClip(Sound sound)
    {
        foreach (GameAssets.SoundAudioClip soundAudioClip in GameAssets.instance.soundAudioClipArray)
        {
            if (soundAudioClip.sound == sound)
            {
                return soundAudioClip.audioClip;
            }
        }

        Debug.LogError("Sound " + sound + " not found!");
        return null;
    }

}
