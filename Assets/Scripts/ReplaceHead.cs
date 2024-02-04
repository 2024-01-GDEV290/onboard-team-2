using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReplaceHead : MonoBehaviour
{
    public GameObject head;
    private void OnTriggerEnter(Collider other)
    {
        Vector3 oldPos = transform.position;
        Instantiate(head, oldPos, Quaternion.identity);
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
