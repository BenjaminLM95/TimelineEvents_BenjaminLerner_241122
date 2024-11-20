using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class openDoorScript : MonoBehaviour
{
    public PlayableDirector timeLine;
    public bool open; 

    private void Start()
    {
        open = false; 
    }

    private void OnTriggerEnter(Collider other)
    {
        if( other.gameObject.CompareTag("Player"))
            {
            if (!open) 
            {
                timeLine.Play();
                open = true;
            }
            

            
        }
    }


}
