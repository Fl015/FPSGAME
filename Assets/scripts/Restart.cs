using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("touched");
        if (collision.gameObject.CompareTag("NPC"))
        {
            SceneManager.LoadScene("RestartScreen");
        }
    }
}
