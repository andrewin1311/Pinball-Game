using UnityEngine;
using UnityEngine.SceneManagement; // Required for scene loading

public class GameOverTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // Check if the ball falls into the trigger zone
        if (other.CompareTag("Ball"))
        {
            SceneManager.LoadScene("gameOver"); // Load the Game Over scene
        }
    }
}
