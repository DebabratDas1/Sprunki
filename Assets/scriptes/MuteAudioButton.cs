using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuteAudioButton : MonoBehaviour
{
    public bool On;
    public GameObject myCharacter;
    private void OnMouseDown()
    {
        if(On == false)
        {
            myCharacter.GetComponent<character>().MycurrentlyAudio.Pause();
            On = true;
        }
        else
        {
            myCharacter.GetComponent<character>().MycurrentlyAudio.Play();
            On = false;
        }
        GetComponent<CircleCollider2D>().enabled = false;
        Invoke("Restme", 0.5f);
    }

    void Restme()
    {
        GetComponent<CircleCollider2D>().enabled = true;
    }
}
