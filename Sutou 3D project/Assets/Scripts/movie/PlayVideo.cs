using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayVideo : MonoBehaviour
{
    public VideoPlayer videoPlayer; // Reference to the VideoPlayer component
    public GameObject playButton; // Reference to the Button component
    // Start is called before the first frame update
    void Start()
    {
        videoPlayer = GetComponent<VideoPlayer>();
    }

    public void PlayVideoClip()
    {
        if(videoPlayer.isPlaying == false)
        {
             videoPlayer.Play();
        }
        else 
        {
            videoPlayer.Pause();
        }
    }

    public void SwitchToHome()
    {
        SceneManager.LoadScene("Home");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
