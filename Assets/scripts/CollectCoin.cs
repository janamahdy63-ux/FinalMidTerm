using UnityEngine;

public class CollectCoin: MonoBehaviour
{
    private AudioSource coinFX;

    void Awake()
    {
        // Automatically get the AudioSource component on this GameObject
        coinFX = GetComponent<AudioSource>();

        if (coinFX == null)
        {
            Debug.LogWarning("No AudioSource found on " + gameObject.name);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (coinFX != null)
        {
            coinFX.Play(); // Play the coin sound
        }

        MasterInfo.coinCount += 1;
        gameObject.SetActive(false);
    }
}