using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;

public class HeadDestroyed : MonoBehaviour
{
    public GameObject thirdHit;

    private async void OnTriggerEnter(Collider other)
    {
        await Task.Delay(700);
        Vector3 oldPos = transform.position;
        Instantiate(thirdHit, oldPos, Quaternion.identity);
        Destroy(gameObject);
    }

    void Update()
    {
        
    }
}
