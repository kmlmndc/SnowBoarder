using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustTrail : MonoBehaviour
{
    [SerializeField] ParticleSystem DustEffect;
    [SerializeField] AudioClip skiSFX;

    void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == "MyGround"){
            GetComponent<AudioSource>().PlayOneShot(skiSFX);
            DustEffect.Play();
        }
    }

    void OnCollisionExit2D(Collision2D other) {
        if(other.gameObject.tag == "MyGround"){
            GetComponent<AudioSource>().Stop();
            DustEffect.Stop();
        }
    }

    
}
