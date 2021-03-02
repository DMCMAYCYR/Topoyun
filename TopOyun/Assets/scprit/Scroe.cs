using System;
using UnityEngine;
using UnityEngine.UI;

public class Scroe : MonoBehaviour
{
    
    public Transform player;
    public Text scoreText;
    public Rigidbody rb;
    string a;
    int x,t;

    private int diffucultLevel = 1;
    private int macDiffuclLevel = 10;
    private int scroToNextLevey = 600;

  
    void Update()
    {
        a= player.position.z.ToString("0");
        x = Convert.ToInt32(a);
        scoreText.text = player.position.z.ToString("0");

        if (x>scroToNextLevey)
        {
            leveUp();
        }

        if (rb.position.y>0)
        {
            if (PlayerPrefs.GetInt("HighScore")<x)
            {
                PlayerPrefs.SetInt("HighScore", x);
                PlayerPrefs.SetInt("ScoreHigh",t);
            }
            PlayerPrefs.SetString("Score",a);    
        }
        
    }

    void leveUp()
    {
        if (diffucultLevel==macDiffuclLevel)
        {
            return;
        }
        scroToNextLevey *= 2;
        diffucultLevel++;

       GetComponent<KarakterMove>().SetSpeed(diffucultLevel);
    }

}
