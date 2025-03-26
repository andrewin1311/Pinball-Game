using UnityEngine;

public class Bumper : MonoBehaviour
{
    public float bounceForce = 10f;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            Rigidbody ballRb = collision.gameObject.GetComponent<Rigidbody>();
            if (ballRb != null)
            {
                // Apply force away from the bumper's center
                Vector3 direction = collision.contacts[0].point - transform.position;
                direction = direction.normalized;

                ballRb.AddForce(direction * bounceForce, ForceMode.Impulse);
            }
        }
    }
}
