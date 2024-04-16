using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] float delayTime = 2f;
    [SerializeField] ParticleSystem FinishEffect;

    void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Player")
        {
            FinishEffect.Play(); 
            GetComponent<AudioSource>().Play();           
            Invoke("ReloadScene", delayTime);
        }
                
    }

    public void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
