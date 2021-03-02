using UnityEngine;
using UnityEngine.UI;

public class GameMenajer : MonoBehaviour
{
    bool gameHasEnding = false;

    public Text score;
    public GameObject ButonSag;
    public GameObject ButonSol;

    public GameObject deathUI;
    public void GameEnd()
    {
        if (gameHasEnding==false)
        {
            ButonSag.SetActive(false);
            ButonSol.SetActive(false);
            score.enabled = false;
            gameHasEnding = true;
            deathUI.SetActive(true);
        }
    }
}
