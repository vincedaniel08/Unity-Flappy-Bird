using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public class SoundManager : MonoBehaviour
{ 


    public static void PlaySound()
    {
        GameObject gameObject = new GameObject("Sound", typeof(AudioSource));
        AudioSource audioSource = gameObject.GetComponent<AudioSource>();
        audioSource.PlayOneShot(GameAssets.GetInstance().birdJump);

    }

    public static void BirdDeath()
    {
        GameObject gameObject = new GameObject("Sound", typeof(AudioSource));
        AudioSource audioSource = gameObject.GetComponent<AudioSource>();
        audioSource.PlayOneShot(GameAssets.GetInstance().birdDeath);

    }

    public static void BirdPoint()
    {
        GameObject gameObject = new GameObject("Sound", typeof(AudioSource));
        AudioSource audioSource = gameObject.GetComponent<AudioSource>();
        audioSource.PlayOneShot(GameAssets.GetInstance().birdPoint);

    }

}
