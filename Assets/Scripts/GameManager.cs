using UnityEngine;
using System.Collections.Generic;
using TMPro;

public class GameManager : MonoBehaviour
{
    public List<GameObject> baskets;
    public AppleSpawner appleSpawner;
    public TMP_Text highscoreText;
    public Basket basketForScore;

    void Start()
    {
        highscoreText.text = "High Score: " + PlayerPrefs.GetInt("Highscore", 0);
    }

    public void LoseBasket()
    {
        if (baskets.Count > 0)
        {
            GameObject b = baskets[baskets.Count - 1];
            baskets.RemoveAt(baskets.Count - 1);
            Destroy(b);
        }

        if (baskets.Count == 0)
        {
            EndGame();
        }
    }

    void EndGame()
    {
        appleSpawner.gameOver = true;

        foreach (GameObject b in baskets)
        {
            b.GetComponent<Basket>().gameOver = true;
        }

        int finalScore = basketForScore.score;
        int currentHigh = PlayerPrefs.GetInt("Highscore", 0);

        if (finalScore > currentHigh)
        {
            PlayerPrefs.SetInt("Highscore", finalScore);
            PlayerPrefs.Save();
        }

        highscoreText.text = "High Score: " + PlayerPrefs.GetInt("Highscore", 0);
    }
}