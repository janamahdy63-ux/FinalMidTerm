using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneReloader : MonoBehaviour
{
    // Call this function to restart the current scene
    public void RestartSampleScene()
    {
        // Reloads the currently active scene (SampleScene if that's what's loaded)
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}