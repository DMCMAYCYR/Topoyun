using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class DeathScore : MonoBehaviour
{
    public Text skor;
   
    public void Start()
    {
        PlayerPrefs.GetString("Score");
    }
    public void Update()
    {
        skor.text = PlayerPrefs.GetString("Score");
    }
}
