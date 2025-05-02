using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainGamesc : MonoBehaviour {

	[SerializeField]
 
     public 	GameObject loadingpanel;
 	 public GameObject mainmenu;
     //public GameObject loadingimg;
	  
    private void Awake()
    {
 		 iOSReviewRequest.Request();
	}
	void Start ()
    {
		 Invoke("showbanner", 10f);
	}
	void showbanner()
    {
		//AdsManagerX.instance.showbanner();
		 loadingpanel.SetActive(false) ;
		 mainmenu.SetActive(true);
//	mainmenu.SetActive(true);
		//AdsManagerX.instance.adsongameover();
		//native.SetActive(true);
    }
	public void RateUs()
    {
//		iOSReviewRequest.Request();
	}
	
}
