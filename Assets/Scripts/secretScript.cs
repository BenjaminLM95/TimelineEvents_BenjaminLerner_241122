using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class secretScript : MonoBehaviour
{
    public AudioSource aSource;
    public AudioClip aClip; 
    // Start is called before the first frame update
    void Start()
    {
        aSource = GetComponent<AudioSource>(); 
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player")) 
        {
            aSource.clip = aClip;
            aSource.Play(); 
        }
    }
}
