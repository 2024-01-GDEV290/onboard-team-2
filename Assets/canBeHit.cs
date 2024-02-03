using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxBehavior : MonoBehaviour
{
    // Flag to track invincibility status
    
    public GameObject boxGameObject;

    private void Start()
    {
        // Make the box invincible when it spawns
        MakeInvincible();
        BoxCollider collider = boxGameObject.GetComponent<BoxCollider>();
        collider.enabled = false;
    }

    private void MakeInvincible()
    {
        
        // Start the coroutine to handle invincibility duration
        StartCoroutine(InvincibilityTimer(1.0f));

    }

    private IEnumerator InvincibilityTimer(float duration)
    {
        // Wait for the specified duration
        yield return new WaitForSeconds(duration);
        // Set invincibility to false after the wait is over
        if (boxGameObject != null)
        {
            BoxCollider collider = boxGameObject.GetComponent<BoxCollider>();
            if (collider != null)
            {
                collider.enabled = true;
            }
        }

    }

    
}

