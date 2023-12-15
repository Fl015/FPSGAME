using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.Video;

public class noJumpScare : MonoBehaviour
{
    public double time;
    float timeLeft = 3;

    private void Start()
    {
        time = GetComponent<VideoPlayer>().clip.length;
    }
    private void Update()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft < 0)
        {
            GameObject.Find("vid").SetActive(false);

        }
    }

}
