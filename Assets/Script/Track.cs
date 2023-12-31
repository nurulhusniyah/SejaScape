using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using UnityEngine.EventSystems;

public class Track : MonoBehaviour
{
    public GameObject mutebutton;
    public GameObject unmutebutton;

    public VideoPlayer video;
    Slider tracking;
    bool slide = false;

    // Start is called before the first frame update
    void Start()
    {
        tracking = GetComponent<Slider>();
    }

    public void press()
    {
        slide = true;
    }

    public void release()
    {
        float frame = (float)tracking.value * (float)video.frameCount;
        video.frame = (long)frame;
        slide = false;
    }

    public void mute()
    {
        video.GetComponent<AudioSource>().mute = true;
        mutebutton.SetActive(false);
        unmutebutton.SetActive(true);
    }

    public void unmute()
    {
        video.GetComponent<AudioSource>().mute = false;
        mutebutton.SetActive(true);
        unmutebutton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (!slide)
        {
        tracking.value = (float)video.frame / (float)video.frameCount;
        }
    }
}
