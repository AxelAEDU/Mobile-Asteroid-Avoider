using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameOverHandler : MonoBehaviour
{
    [SerializeField] private TMP_Text gameOverText;
    [SerializeField] private ScoreSystem scoreSystem;
    [SerializeField] private GameObject gamOverDisplay;
    [SerializeField] private AsteroidSpawner asteroidSpawner;
    public void EndGame()
    {
        asteroidSpawner.enabled = false;

        int finalScore = scoreSystem.Endtimer();
        gameOverText.text = $"Your Score: {finalScore}";

        gamOverDisplay.gameObject.SetActive(true);

    }
    public void PlayAgain()
    {
        SceneManager.LoadScene(1);
    }

        public void Continue()
    {
        SceneManager.LoadScene(1);
    }

        public void ReturnToMenu()
    {
        SceneManager.LoadScene(0);
    }
}
