using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class MusicFondo : MonoBehaviour
{
    public AudioMixerSnapshot soundFondo;
    public AudioMixerSnapshot soundIndoor;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        soundFondo.TransitionTo(0.5f);
    }

    private void OnTriggerEnter(Collider other)
    {
        soundIndoor.TransitionTo(0.5f);
    }

}
