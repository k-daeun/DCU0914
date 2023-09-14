using UnityEngine;

public class Move : MonoBehaviour
{
    public float moveSpeed = 5.0f; // Adjust this value to control the movement speed.

    private void Update()
    {
        // Get input from the player.
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Calculate the movement direction based on player input.
        Vector3 movementDirection = new Vector3(horizontalInput, 0.0f, verticalInput);

        // Normalize the direction vector to ensure consistent speed regardless of the input magnitude.
        if (movementDirection.magnitude > 1.0f)
        {
            movementDirection.Normalize();
        }

        // Calculate the desired movement amount based on the speed and time.
        Vector3 movement = movementDirection * moveSpeed * Time.deltaTime;

        // Move the player character.
        transform.Translate(movement);
    }
}
