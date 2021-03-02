using UnityEngine.SceneManagement;
using UnityEngine;
using GoogleMobileAds.Api;

public class Buton : MonoBehaviour
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

    public void Yeniden()
    {
        if (gecisReklam.IsLoaded())
        {
            gecisReklam.Show();
        }
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Cık()
    {
        if (gecisReklam.IsLoaded())
        {
            gecisReklam.Show();
        }
        SceneManager.LoadScene("AnaMenu");
    }
}
