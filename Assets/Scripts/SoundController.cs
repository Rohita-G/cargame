using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    public AudioSource takeOff, acceleration;
    void Start()
    {
        Invoke("TurnOnAcceleration",3f);
    }

    // Update is called once per frame
    void TurnOnAcceleration()
    {
        takeOff.Stop();
        acceleration.Play();
    }
}
