using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class openDoorScript : MonoBehaviour
{
    public PlayableDirector openDoor;
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
                openDoor.Play();
                open = true;
            }
            

            
        }
    }


}
