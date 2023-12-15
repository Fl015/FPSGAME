using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class RestartMenu : MonoBehaviour
{
    public void RestartGame()
    {
        SceneManager.LoadScene(2);
    }   

}
