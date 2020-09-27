using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class calistir : MonoBehaviour
{
    public AudioSource sesKaynagi;
    public AudioClip klib;
    void Start()
    {
        sesKaynagi = this.GetComponent<AudioSource>();
        sesKaynagi.clip = klib;
    }

    // Update is called once per frame
    void Update()
    {
        
        sesKaynagi.Play();
    }
}
