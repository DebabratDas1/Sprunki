using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Gamemanager : MonoBehaviour
{
    public static Gamemanager instnce;
    public AudioSource[] AllAudios;
    public GameObject[] AllCharacters;
    public GameObject[] AllPopupButtons;
    public SpriteRenderer[] AllFrontBackgrounds;
    public int count;
    private void Awake()
    {
        instnce = this;
    }

   public void ResumAudios()
    {
        if (AllCharacters[0].GetComponent<character>().IsAudioOn == true)
        {
            AllCharacters[0].GetComponent<character>().MycurrentlyAudio.Play();
        }
        if (AllCharacters[1].GetComponent<character>().IsAudioOn == true)
        {
            AllCharacters[1].GetComponent<character>().MycurrentlyAudio.Play();
        }
        if (AllCharacters[2].GetComponent<character>().IsAudioOn == true)
        {
            AllCharacters[2].GetComponent<character>().MycurrentlyAudio.Play();
        }
        if (AllCharacters[3].GetComponent<character>().IsAudioOn == true)
        {
            AllCharacters[3].GetComponent<character>().MycurrentlyAudio.Play();
        }
        if (AllCharacters[4].GetComponent<character>().IsAudioOn == true)
        {
            AllCharacters[4].GetComponent<character>().MycurrentlyAudio.Play();
        }
        if (AllCharacters[5].GetComponent<character>().IsAudioOn == true)
        {
            AllCharacters[5].GetComponent<character>().MycurrentlyAudio.Play();
        }
        if (AllCharacters[6].GetComponent<character>().IsAudioOn == true)
        {
            AllCharacters[6].GetComponent<character>().MycurrentlyAudio.Play();
        }
    }

    public void Home()
    {
        SceneManager.LoadScene(1);
    }
}
