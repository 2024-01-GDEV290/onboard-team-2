using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DisableColliderOnCollision : MonoBehaviour
{
    private BoxCollider boxCollider;

    private void Awake()
    {
        // Get the BoxCollider component attached to the GameObject
        boxCollider = GetComponent<BoxCollider>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        boxCollider.enabled = false;
        Debug.Log("disabled");
        // When a collision occurs, start the DisableForSeconds Coroutine
        StartCoroutine(DisableForSeconds(3f)); // 3 seconds delay
        
    }

    IEnumerator DisableForSeconds(float seconds)
    {
        // Disable the BoxCollider
        

        // Wait for the specified number of seconds
        yield return new WaitForSeconds(seconds);

        // Re-enable the BoxCollider
        boxCollider.enabled = true;
        Debug.Log("enabled");
    }
}

