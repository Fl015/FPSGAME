using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class footsteps : MonoBehaviour
{
    public AudioSource footstepSound;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) || (Input.GetKeyDown(KeyCode.A)) || (Input.GetKeyDown(KeyCode.S)) || (Input.GetKeyDown(KeyCode.D)))
        {
            footstepSound.enabled = true;
        }
        else 
        { 
            footstepSound.enabled = false; 
        }
    }
}
