using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{

    AudioSource background_audio;

    // Start is called before the first frame update
    void Start()
    {
        background_audio = GetComponent<AudioSource>();
        background_audio.PlayDelayed(4.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
