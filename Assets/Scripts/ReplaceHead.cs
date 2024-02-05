using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;

public class ReplaceHead : MonoBehaviour
{
    public GameObject head;
    private async void OnTriggerEnter(Collider other)
    {
        await Task.Delay(700);
        Vector3 oldPos = transform.position;
        Instantiate(head, oldPos, Quaternion.identity);
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
