using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadDestroyed : MonoBehaviour
{
    public GameObject thirdHit;

    private void OnTriggerEnter(Collider other)
    {
        Vector3 oldPos = transform.position;
        Instantiate(thirdHit, oldPos, Quaternion.identity);
        Destroy(gameObject);
    }

    void Update()
    {
        
    }
}
