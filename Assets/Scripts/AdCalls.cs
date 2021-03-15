
using System;
using UnityEngine;
using EasyMobile;
using System.Collections;
using UnityEngine.Advertisements;
public class AdCalls : MonoBehaviour {

    public string UnityId;
   // public GameObject noVideo;
    public static AdCalls Instant;
    private int adcall = 0;
    private void Awake()
    {
        Instant = this;
      
    }

    void OnEnable()
    {
        Advertising.RewardedAdCompleted += OnRewardedAdCompleted;
    }

    void OnDisable()
    {
        Advertising.RewardedAdCompleted -= OnRewardedAdCompleted;
    }
    void OnRewardedAdCompleted(RewardedAdNetwork arg1, AdLocation arg2)
    {
        PlayerPrefs.SetInt("Cash", PlayerPrefs.GetInt("Cash") + 500);
    }
    private void Start()
    {

        AdSettings.DefaultAdNetworks defaultNetworks = new AdSettings.DefaultAdNetworks(BannerAdNetwork.AdMob, InterstitialAdNetwork.AdMob, RewardedAdNetwork.AdMob);
        Advertising.ShowBannerAd(BannerAdPosition.Bottom);

#if UNITY_ANDROID
        defaultNetworks = EM_Settings.Advertising.AndroidDefaultAdNetworks;
#endif

        LoadRewardedAd();
        Advertising.LoadInterstitialAd();
        Advertisement.Initialize(UnityId, false);
    }
    public void AdmobInterstitial()
    {
        adcall++;
        Advertising.LoadInterstitialAd();
        if (adcall ==2)
        {
            AdMobRewarded();
        }
        else
        {
            if (Advertising.IsInterstitialAdReady(InterstitialAdNetwork.AdMob, AdLocation.Default))
            {
                Debug.Log("AdMob Inter Showed Here");
                Advertising.ShowInterstitialAd(InterstitialAdNetwork.AdMob, AdLocation.Default);
            }
            

           
        }

        Advertising.LoadInterstitialAd();
      

    }

    public void UnityInterstitial()
    {
//        if (Advertisement.IsReady())
//        {
//            Advertisement.Show();
//        }
//        else
        {
            if (Advertising.IsInterstitialAdReady(InterstitialAdNetwork.AdMob, AdLocation.Default))
                Advertising.ShowInterstitialAd(InterstitialAdNetwork.AdMob, AdLocation.Default);
            Advertising.LoadInterstitialAd();
        }
        Debug.Log("Video Ad Presents here");
    }
    public void AdMobRewarded()
    {
        if (Advertising.IsRewardedAdReady())
        {
            Advertising.ShowRewardedAd();
        }
//        else
//            if (Advertisement.IsReady("rewardedVideo"))
//        {
//            var options = new ShowOptions { resultCallback = HandleShowResult };
//            Advertisement.Show("rewardedVideo", options);
//        }
//        else
//        {
//           // noVideo.SetActive(true);
//            StartCoroutine("inactive", 2f);
//        }
        LoadRewardedAd();
    }
    IEnumerator inactive(float duration)
    {
        yield return new WaitForSeconds(duration);
          //  noVideo.SetActive(false);
    }
    public void LoadRewardedAd()
    {
        if (Advertising.IsAutoLoadDefaultAds())
        {
        }
        Advertising.LoadRewardedAd();
    }

    /// <summary>
    /// Shows the rewarded ad.
    /// </summary>
    private void HandleShowResult(ShowResult result)
    {
        switch (result)
        {
            case ShowResult.Finished:
                Debug.Log("The ad was successfully shown.");
                PlayerPrefs.SetInt("Cash", PlayerPrefs.GetInt("Cash") + 500);
                break;
            case ShowResult.Skipped:
                Debug.Log("The ad was skipped before reaching the end.");
                break;
            case ShowResult.Failed:
                Debug.LogError("The ad failed to be shown.");
                break;
        }
    }

    public void _Bike_Game_Ad() {
        Application.OpenURL("https://play.google.com/store/apps/details?id=mountainbike.stunts.joker");

    }
}
