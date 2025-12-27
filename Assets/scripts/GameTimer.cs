using TMPro;
using UnityEngine;

public class GameTimer : MonoBehaviour
{
    [SerializeField] private TMP_Text timerText;         // Drag your Timer TMP Text here
    [SerializeField] private GameObject gameOverPanel;   // Drag your Background panel here

    private float timeRemaining = 60f;
    private bool timerIsRunning = false;

    void Start()
    {
        timerIsRunning = true;
        gameOverPanel.SetActive(false); // hide Game Over panel at start
    }

    void Update()
    {
        if (!timerIsRunning) return;

        timeRemaining -= Time.deltaTime;
        timerText.text = Mathf.Ceil(timeRemaining).ToString();

        if (timeRemaining <= 0)
        {
            timerIsRunning = false;
            gameOverPanel.SetActive(true); // show Game Over panel
            Time.timeScale = 0f; // pause the game
        }
    }
}
