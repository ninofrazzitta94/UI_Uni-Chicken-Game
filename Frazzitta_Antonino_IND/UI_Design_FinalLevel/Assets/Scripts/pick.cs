using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pick : MonoBehaviour
{
    // Start is called before the first frame update

    AudioSource audioSource;
    [SerializeField] public AudioClip pickCoin;
    [SerializeField] public AudioClip pickApple;
    [SerializeField] public AudioClip pickKey;
    [SerializeField] public AudioClip pickChest;
    void Start() 
    {
        audioSource = GetComponent<AudioSource>();
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Coin")
        {
          pickCoin = col.GetComponent<AudioClip>();
            audioSource.Play();
            Debug.Log("you have collected: " + gameObject.name);
        }
        else if (col.gameObject.tag == "Key")
        {
            pickKey = col.GetComponent<AudioClip>();
            audioSource.Play();
            Debug.Log("you have collected: " + gameObject.name);
        }

    }
}
