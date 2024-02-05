using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxingGloveCollision : MonoBehaviour
{
    public GameObject headShattered;
    public GameObject headBase;
    public GameObject phaseTwo;
    public GameObject shardsOne;
    public GameObject shardsTwo;
    public GameObject shardsThree;
    public GameObject phaseThree;
    public GameObject PSLeft;
    public GameObject PSRight;
    public AudioClip punch1;
    public AudioClip crumble1;
    public AudioClip crumble2;
    public AudioClip crumble3;
    public AudioClip flameOn;
    public AudioClip flameCrinkle;
    private AudioSource audioSource;
    public int hitCount = 0;
    

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        hitCount = 0;
    }

    void OnTriggerEnter(Collider other)
    {
        

        if (other.gameObject.tag == "glove")
        {
            hitCount++;

            if (punch1 != null && audioSource != null && hitCount == 1)
            {
                audioSource.PlayOneShot(punch1);
                audioSource.PlayOneShot(crumble1);
                phaseTwo.SetActive(true);
                shardsOne.SetActive(true);
                headBase.SetActive(false);
            }

            if (punch1 != null && audioSource != null && hitCount == 2)
            {
                audioSource.PlayOneShot(punch1);
                audioSource.PlayOneShot(crumble2);
                /*audioSource.PlayOneShot(flameCrinkle);
                audioSource.PlayOneShot(flameOn);
                PSLeft.SetActive(true);
                PSRight.SetActive(true);*/
                phaseTwo.SetActive(false);
                shardsTwo.SetActive(true);
                phaseThree.SetActive(true);
               
            }

            if (punch1 != null && audioSource != null && hitCount == 3)
            {
                audioSource.PlayOneShot(punch1);
                audioSource.PlayOneShot(crumble3);
                phaseThree.SetActive(false);
                shardsThree.SetActive(true);

            }

        }




    }
}
