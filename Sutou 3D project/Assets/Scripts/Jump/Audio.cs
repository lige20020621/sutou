using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    public static Audio soundMan;
    private AudioSource audioSrc;

    public AudioClip sk_1_Sound;


    // Start is called before the first frame update
    void Start()
    {
        soundMan = this;
        audioSrc = this.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }


    public void Play_sk_1_Sound()
    {
        audioSrc.Stop();
        audioSrc.PlayOneShot(sk_1_Sound);
    }
}
