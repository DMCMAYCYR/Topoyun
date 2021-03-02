using System;
using UnityEngine;

public class PlayerColli : MonoBehaviour
{
    public KarakterMove move;
    int a;
  
    void OnCollisionEnter(Collision coll)
    {
        if (coll.collider.tag=="enemy")
        {
            if (PlayerPrefs.GetInt("HighScore")<PlayerPrefs.GetInt("ScoreHigh"))
            {
                PlayerPrefs.SetInt("HighScore", a);
            }
            move.enabled = false;
            FindObjectOfType<GameMenajer>().GameEnd();
        }
    }
}
