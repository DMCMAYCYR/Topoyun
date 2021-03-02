using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using GoogleMobileAds.Api;

public class Basla : MonoBehaviour
{
    private InterstitialAd gecisReklam;

    string appID = "ca-app-pub-7993224500204628~3868918084";
    string instertitialID = "ca-app-pub-7993224500204628/4957487099";

    void Start()
    {
        MobileAds.Initialize(appID);

        gecisReklam = new InterstitialAd(instertitialID);
        AdRequest YeniReklam = new AdRequest.Builder().Build();
        gecisReklam.LoadAd(YeniReklam);
    }

    public void basla()
    {
        if (gecisReklam.IsLoaded())
        {
            gecisReklam.Show();
        }

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void cık()
    {
        Application.Quit();
    }
  
}
