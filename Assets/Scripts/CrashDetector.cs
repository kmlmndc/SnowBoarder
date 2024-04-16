using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] float delayTime = 1f;
    [SerializeField] ParticleSystem crashEffect;
    [SerializeField] AudioClip crashSFX;
    bool crashStatus = false;

    void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "MyGround" && !crashStatus)
        {
            crashStatus = true;
            crashEffect.Play();
            GetComponent<AudioSource>().PlayOneShot(crashSFX);
            Invoke("ReloadScene", delayTime);
            FindObjectOfType<PlayerController>().DisableControls();
        }
    }

    public void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
