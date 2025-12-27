using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 20f;
    public float rightLimit = 20f;
    public float leftLimit = -20f;

    void Update()
    {
        float horizontal = 0f;
        float vertical = 0f;

        // Forward / Backward
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
            vertical = 1f;

        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
            vertical = -1f;

        // Left / Right
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            horizontal = -1f;

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            horizontal = 1f;

        // Move player within limits
        Vector3 move = new Vector3(horizontal, 0, vertical);
        Vector3 newPosition = transform.position + move * speed * Time.deltaTime;

        // Check limits
        if (newPosition.x > rightLimit)
            newPosition.x = rightLimit;
        if (newPosition.x < leftLimit)
            newPosition.x = leftLimit;

        transform.position = newPosition;
    }
}