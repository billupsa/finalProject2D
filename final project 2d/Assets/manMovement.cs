using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manMovement : MonoBehaviour
{
    public static Animator man;
    public int killCount,timer = 0;
    public bool death = false;
    public float speed;

    

    // Start is called before the first frame update
    void Start()
    {
        man = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    //Controls for the player
    //Maps out all 4 directions: D for right, A for left, S for down, W for up
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            man.SetBool("walkingRight", true);
            transform.Translate(transform.right * Time.deltaTime * speed);

        }
        else
        {
            man.SetBool("walkingRight", false);
        }

        
        if (Input.GetKey(KeyCode.A))
        {
            man.SetBool("walkingLeft", true);
            transform.Translate(-transform.right * Time.deltaTime * speed);
           
        }
        else
        {
            man.SetBool("walkingLeft", false);
        }



        if (Input.GetKey(KeyCode.W))
        {
            man.SetBool("walkingForward", true);
            transform.Translate(transform.up* Time.deltaTime * speed);

        }
        else
        {
            man.SetBool("walkingForward", false);
        }

      
        if (Input.GetKey(KeyCode.S))
        {
            man.SetBool("walkingBack", true);
            transform.Translate(-transform.up * Time.deltaTime * speed);

            
        }
        else
        {
            man.SetBool("walkingBack", false);
        }

        //An if and else statement to trigger the death animation
        //If the statCounter differs from the interal killCount then the death animation is called
        if (statCounter.kills > killCount)
        {
            man.SetBool("death", true);
            death = true;
            killCount++;
        }
        else
        {
            //If death is true then a timer starts to give a break between being idle and death
            if (death)
            {
                while (timer < 5)
                {
                    timer++;
                }
                if (timer == 5)
                {
                    man.SetBool("death", false);
                    timer = 0;
                }
            }
            
            
        }
    }

   

       



    
}
