using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class headHealth : MonoBehaviour
{
    public GameObject headShattered;
    public GameObject headBase;

    public int hitCount = 0;


    void Start()
    {
        
        hitCount = 0;
    }

    void OnTriggerEnter(Collider other)
    {


        if (other.gameObject.name == "gloveLeft")
        {
            hitCount++;

            if (hitCount == 1)
            {
                headBase.SetActive(false);
                headShattered.SetActive(true);
            }

        }




    }
}

