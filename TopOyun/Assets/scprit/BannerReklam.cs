using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;

public class BannerReklam : MonoBehaviour
{
    private BannerView bannerReklam;
    string bannerID = "ca-app-pub-7993224500204628/9547963639";

    string appID = "ca-app-pub-7993224500204628~3868918084";

    public AdPosition position;
    // Start is called before the first frame update
    void Start()
    {
        MobileAds.Initialize(appID);

        bannerReklam = new BannerView(bannerID, AdSize.Banner, position);

        AdRequest yeniReklam = new AdRequest.Builder().Build();

        bannerReklam.LoadAd(yeniReklam);


    }

    // Update is called once per frame
    void Update()
    {
        bannerReklam.Show();
    }
}
