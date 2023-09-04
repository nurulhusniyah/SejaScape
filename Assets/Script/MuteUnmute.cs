using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using Vuforia;

public class MuteUnmute : MonoBehaviour
{

    public GameObject mutebutton;
    public GameObject unmutebutton;

    public ImageTargetBehaviour objectAr;
  
    public void mute()
    {
        objectAr.GetComponent<AudioSource>().mute = true;
        mutebutton.SetActive(false);
        unmutebutton.SetActive(true);
    }

    public void unmute()
    {
        objectAr.GetComponent<AudioSource>().mute = false;
        mutebutton.SetActive(true);
        unmutebutton.SetActive(false);
    }
}
