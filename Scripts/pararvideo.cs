using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class pararvideo : MonoBehaviour
{
    public VideoPlayer videoPlayer;

    void Start()
    {
        if (videoPlayer == null)
        {
            Debug.LogError("VideoPlayer not assigned");
            return;
        }

        videoPlayer.loopPointReached += EndReached;
    }

    void EndReached(VideoPlayer vp)
    {
        // Hide or disable the video player
        videoPlayer.gameObject.SetActive(false);
    }
}


