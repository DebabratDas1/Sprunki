using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadPhoneButton : MonoBehaviour
{
    public GameObject myCharacter;
    public bool On;

    private void OnMouseDown()
    {
        if(On == false)
        {
            foreach (AudioSource item in Gamemanager.instnce.AllAudios)
            {
                item.Pause();

            }
            myCharacter.GetComponent<character>().MycurrentlyAudio.Play();
            On = true;
        }
        else
        {
            Gamemanager.instnce.ResumAudios();
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
