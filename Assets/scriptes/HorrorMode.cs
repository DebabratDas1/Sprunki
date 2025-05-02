using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorrorMode : MonoBehaviour
{

    public GameObject FadePanel;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("HideFadePanel", 4f);
    }

   void HideFadePanel()
    {
        FadePanel.SetActive(false);
    }
}
