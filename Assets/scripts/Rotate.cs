using UnityEngine;

public class RotateAllAxes : MonoBehaviour
{
    [Header("Rotation Speed (Degrees per Second)")]
    public Vector3 rotationSpeed = new Vector3(30f, 60f, 90f);

    void Update()
    {
        // Rotate smoothly on all axes, frame-rate independent
        transform.Rotate(rotationSpeed * Time.deltaTime);
    }
}