using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changingBlocks : MonoBehaviour
{
    // Start is called before the first frame update

    public Transform starter;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

    }

    //when the player enters the object, they get telported to the next round and the rounds increase
    public void OnTriggerEnter2D(Collider2D collision)
    {
        manMovement.man.transform.position = starter.transform.position;
        rounds.round++;
    }
}
