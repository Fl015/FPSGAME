using UnityEngine;
using UnityEngine.Video;

public class theScare : MonoBehaviour
{
    public VideoSource jumpScare;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("NPC"))
        {
            //jumpScare.enabled = true;
        }
        else
        {
            //jumpScare.enabled = false;
        }
    }
}
