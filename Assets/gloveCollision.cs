using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxingGloveCollision : MonoBehaviour
{
    public GameObject headShattered;
    public GameObject headBase;
    public GameObject phaseTwo;
    public AudioClip punch1;
    public AudioClip crumble1;
    public AudioClip crumble2;
    public AudioClip crumble3;
    private AudioSource audioSource;
    public int hitCount = 0;
    

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        hitCount = 0;
    }

    void OnTriggerEnter(Collider other)
    {
        

        if (other.gameObject.name == "headBase")
        {
            hitCount++;

            if (punch1 != null && audioSource != null && hitCount == 1)
            {
                audioSource.PlayOneShot(punch1);
                audioSource.PlayOneShot(crumble1);
                
            }

            if (punch1 != null && audioSource != null && hitCount == 2)
            {
                audioSource.PlayOneShot(punch1);
                audioSource.PlayOneShot(crumble2);

            }

            if (punch1 != null && audioSource != null && hitCount == 3)
            {
                audioSource.PlayOneShot(punch1);
                audioSource.PlayOneShot(crumble3);
                headBase.SetActive(false);
                headShattered.SetActive(true);
            }

        }




    }
}
