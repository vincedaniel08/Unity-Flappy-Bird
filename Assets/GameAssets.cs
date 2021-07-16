using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameAssets : MonoBehaviour
{
    private static GameAssets instance;

    // Start is called before the first frame update
    public static GameAssets GetInstance()
    {
        return instance;
        
    }

    // Update is called once per frame
    private void Awake()
    {
        instance = this;
    }

    public AudioClip birdJump;
    public AudioClip birdDeath;
    public AudioClip birdPoint;

}
