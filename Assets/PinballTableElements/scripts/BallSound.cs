using UnityEngine;

public class BallSound : MonoBehaviour
{
    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();  // Get the AudioSource component
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ball")) // Play sound when ball hits
        {
            audioSource.Play();
        }
    }
}
