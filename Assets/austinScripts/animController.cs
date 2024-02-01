using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animController : MonoBehaviour
{
    Animator anim1;
    public int punchNumber = 1;


    // Start is called before the first frame update
    void Start()
    {
        anim1 = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
         
        
            if (Input.GetMouseButtonDown(0))
            {
                anim1.SetTrigger("punchRight");
                
                
            }
        

       
            if (Input.GetMouseButtonDown(1))
            {
                anim1.SetTrigger("punchLeft");

        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            anim1.SetTrigger("chargeUp");

        }

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            anim1.SetTrigger("finalPunch");

        }
    }
}
