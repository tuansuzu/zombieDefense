using UnityEngine;
using System.Collections;

public class AdController
{
    private static float lastAdTime = float.MinValue;

    public static void CheckAndShowAd()
    {
        if (Time.time - lastAdTime < 90) return;
        bool isRemoveAd = PlayerPrefs.GetInt("isRemoveAd", 0) == 0 ? false : true;
        if (isRemoveAd) return;

#if UNITY_ANDROID || UNITY_IPHONE
        bool result = AdmobController.instance.ShowInterstitial();
        if (result == false) AdmobController.instance.RequestInterstitial();
#endif
        lastAdTime = Time.time;
    }

    public static void ShowBanner()
    {
        bool isRemoveAd = PlayerPrefs.GetInt("isRemoveAd", 0) == 0 ? false : true;
        if (isRemoveAd) return;

#if UNITY_ANDROID || UNITY_IPHONE
        AdmobController.instance.ShowBanner();
#endif
    }

    public static void HideBanner()
    {
#if UNITY_ANDROID || UNITY_IPHONE
        AdmobController.instance.HideBanner();
#endif
    }
}