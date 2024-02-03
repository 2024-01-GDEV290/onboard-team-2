using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxingGloveCollision : MonoBehaviour
{
    public GameObject headShattered;
    public GameObject phaseTwo;
    public AudioClip punch1;
    public AudioClip crumble1;
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void OnCollisionEnter(Collision collision)
    {
        // Check if the object we collided with is the box
        if (collision.gameObject.name == "headBase")
        {
            // Apply force to the box
            Vector3 forceDirection = collision.contacts[0].point - transform.position;
            forceDirection = -forceDirection.normalized; // Apply force in the opposite direction of the collision
            collision.rigidbody.AddForce(forceDirection * 500); // Modify the force magnitude as needed
            Debug.Log("collision");

            if (punch1 != null && audioSource != null)
            {
                audioSource.PlayOneShot(punch1);
                audioSource.PlayOneShot(crumble1);
            }

            Destroy(collision.gameObject);

            

            if (headShattered != null)
            {
                headShattered.SetActive(true);
            }

            if (phaseTwo != null)
            {
                phaseTwo.SetActive(true);
            }
        }
    }
}
