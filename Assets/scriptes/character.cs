using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class character : MonoBehaviour
{
    public GameObject ShowminePopup;
    public AudioSource MycurrentlyAudio;
    public GameObject MyButton;
    public bool IsAudioOn;
    // Start is called before the first frame update
    void Start()
    {
        float index = Random.Range(0, 15);
        Invoke("StartAnim", index);


    }
    void StartAnim()
    {
        GetComponent<Animator>().enabled = true;
    }
    private void OnMouseDown()
    {

        if (gameObject.CompareTag("none"))
         {
            foreach(GameObject item in Gamemanager.instnce.AllPopupButtons)
            {
                item.SetActive(false);
            }

            ShowminePopup.SetActive(true);
        }
    }
   public void backToIdel()
    {
        Invoke("idel",1f);
    }
    void idel()
    {
        gameObject.tag = ("DropTarget");
    }
}
