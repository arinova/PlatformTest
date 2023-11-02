using UnityEngine;
using System.Collections;

public class GameSounds : MonoBehaviour
{
    public AudioSource audioSource;

    public void playAudio() {
        if (audioSource != null)
        {
            audioSource.Play();
        }
    }
}
