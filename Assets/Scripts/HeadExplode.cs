using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadExplode : MonoBehaviour
{
    public GameObject thirdHit;

    void OnTriggerEnter(Collider other)
    {
        Vector3 oldPos = transform.position;
        Instantiate(thirdHit, oldPos, Quaternion.identity);
        Destroy(gameObject);
    }
}
