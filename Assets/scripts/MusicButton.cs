using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicButton : MonoBehaviour
{
    public GameObject mysic;
    public GameObject stop;
    public GameObject play;

    public void PressPlayButon()
    {
        mysic.GetComponent<AudioSource>().Play();
        play.SetActive(false);
        stop.SetActive(true);
    }

    public void PressStopButon()
    {
        mysic.GetComponent<AudioSource>().Pause();
        play.SetActive(true);
        stop.SetActive(false);
    }

}
