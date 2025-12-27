using TMPro;
using UnityEngine;

public class GameTimerActivate : MonoBehaviour
{
    [SerializeField] private TMP_Text timerText;      // Drag your Timer TMP Text here
    [SerializeField] private GameObject objectToActivate; // Drag the GameObject you want to activate

    [SerializeField] private float timeRemaining = 60f;  // Set your countdown time
    private bool timerIsRunning = false;

    void Start()
    {
        timerIsRunning = true;
        if (objectToActivate != null)
            objectToActivate.SetActive(false); // Ensure it's hidden at the start
    }

    void Update()
    {
        if (!timerIsRunning) return;

        timeRemaining -= Time.deltaTime;
        timerText.text = Mathf.Ceil(timeRemaining).ToString();

        if (timeRemaining <= 0f)
        {
            timerIsRunning = false;

            if (objectToActivate != null)
                objectToActivate.SetActive(true); // Activate the object when time runs out
        }
    }
}
