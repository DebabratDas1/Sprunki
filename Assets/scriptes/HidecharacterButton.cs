using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HidecharacterButton : MonoBehaviour
{
    public GameObject myCharacter;
    public GameObject Mybackground;
    public Sprite IdelSprite;
    private void OnMouseDown()
    {
        myCharacter.GetComponent<Animator>().SetInteger("mov",-1);
        myCharacter.GetComponent<character>().MycurrentlyAudio.Stop();
        Mybackground.SetActive(true);
        myCharacter.GetComponent<character>().IsAudioOn = false;
       Invoke("resttoidel", 0.5f);
    }
     
   void resttoidel()
    {
        myCharacter.GetComponent<SpriteRenderer>().sprite = IdelSprite;
        myCharacter.GetComponent<character>().backToIdel();
        myCharacter.GetComponent<character>().MyButton.SetActive(true);
        myCharacter.GetComponent<character>().MyButton.GetComponent<DragAndDrop>().backtodefultpostion();
      Mybackground.SetActive(false);

    }
    
}
