using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoManager : MonoBehaviour
{
    public VideoPlayer player;

    public void StartOrPauseVideo()
    {
        if (player.isPlaying)
        {
            player.Pause();
        }
        else
        {
            player.Play();
        }
    }

    private void SetTime(int time)
    {
        player.frame = (long)(time * player.frameRate);
        player.Play();
    }

    public void OnValueChanged(float value)
    {
        SetTime((int)value);

    }
}