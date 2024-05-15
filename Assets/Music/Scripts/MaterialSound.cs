using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialSound : MonoBehaviour
{
    public AudioClip[] footstepsOnGrass;
    public AudioClip[] footstepsOnWood;
    public AudioClip[] footstepsOnRoca;
    public AudioClip[] footstepsOnSuelo;
    public AudioClip[] footstepsOnTable;

    public string material;

    void PlayFootstepSound()
    {
        AudioSource myAudioSource = GetComponent<AudioSource>();
        myAudioSource.pitch = Random.Range(0.8f, 1.2f);
        myAudioSource.volume = Random.Range(0.8f, 1.0f);

        switch (material)
        {
            case "Grass":
                myAudioSource.PlayOneShot(footstepsOnGrass[Random.Range(0, footstepsOnGrass.Length)]);
                break;

            case "Wood":
                myAudioSource.PlayOneShot(footstepsOnWood[Random.Range(0, footstepsOnWood.Length)]);
                break;
            case "roca":
                myAudioSource.PlayOneShot(footstepsOnRoca[Random.Range(0, footstepsOnRoca.Length)]);
                break;
            case "Suelo":
                myAudioSource.PlayOneShot(footstepsOnSuelo[Random.Range(0, footstepsOnSuelo.Length)]);
                break;
            case "Table":
                myAudioSource.PlayOneShot(footstepsOnTable[Random.Range(0, footstepsOnTable.Length)]);
                break;

            default:
                break;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        switch (collision.gameObject.tag)
        {
            case "Grass":
            case "Wood":
                material = collision.gameObject.tag;
                break;
            case "roca":
                material = collision.gameObject.tag;
                break;
            case "Suelo":
                material = collision.gameObject.tag;
                break;
            case "Table":
                material = collision.gameObject.tag;
                break;

            default:
                break;
        }
    }
}