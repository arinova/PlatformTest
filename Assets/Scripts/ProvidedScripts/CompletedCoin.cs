using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompletedCoin : MonoBehaviour
{
    public AudioSource audioSource;

    //Very simple script just listens to see if something touches it
    public void OnTriggerEnter2D(Collider2D collision)
    {
        //If it does touch something, print a message and destroy this coin
        Debug.Log("Coin Collected!");

        //Play a Jump Sound
        if (audioSource != null)
        {
            audioSource.Play();
        }
        Destroy(this.gameObject);
    }
}
