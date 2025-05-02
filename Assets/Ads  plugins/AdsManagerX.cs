using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class AdsManagerX : MonoBehaviour
{
    public static AdsManagerX instance;

 
    static int Count;
    static int Count1;
    [HideInInspector]
    public string PromoteLink;
    [HideInInspector]
    public string PromoteTitle;
    Data data = new Data();
    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        SetUserConsent();
    
    }
    public void SetUserConsent()
    {
      // Advertisements.Instance.SetUserConsent(true);
     // Advertisements.Instance.Initialize();
    }
    public void adsongameover()
    {
       if(Count == 0)
        {
            GetComponent<InterstitialAd>().LoadAd();
            GetComponent<InterstitialAd>().ShowAd();
            Count++;
        }
        else
        {
            
            Gley.MobileAds.API.ShowInterstitial();
            Count = 0;
        }
  
                
                
     
       
    }
//    public RewardedAdsButton UnityVideoAds;
   
    public void LoadRewaredads()
    {
     //   UnityVideoAds.LoadAd();
        Gley.MobileAds.API.IsRewardedVideoAvailable();
    }
     
    public void ShowVidoeAdsContinue()
    {
        if (Gley.MobileAds.API.IsRewardedVideoAvailable())
        {
            Gley.MobileAds.API.ShowRewardedVideo(CompleteMethod);
        }
        
    }
    private void CompleteMethod(bool completed)
    {
        if (completed)
        {
         //   Gamemanager.instance.ClickOncountune();
          //  Time.timeScale = 1;
        }
        
    }
    
    public void ShowVidoeAdsGuns(GameObject GunLockerId)
    {
        if (Gley.MobileAds.API.IsRewardedVideoAvailable())
        {
            Gley.MobileAds.API.ShowRewardedVideo(CompleteMethodGuns);
        }
        
     //   Gunlocker = GunLockerId;
    }
    private void CompleteMethodGuns(bool completed)
    {
        if (completed)
        {
         //   Gunlocker.SetActive(false);
         //   Time.timeScale = 0;
        }

    }

    public void SHowadmobIntestital()
    {
        if (Count1 == 0)
        {
            GetComponent<InterstitialAd>().LoadAd();
            GetComponent<InterstitialAd>().ShowAd();
            Count1++;
        }
        else
        {

            Gley.MobileAds.API.ShowInterstitial();
            Count1 = 0;
        }
    }

    
}
