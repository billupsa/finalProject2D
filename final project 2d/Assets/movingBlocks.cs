using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingBlocks : MonoBehaviour
{
    public Transform position1, position2, starter;
    public float speed;
    //  private Animator man;
    public Transform startPosition;
    Vector3 nextPosition;

    // nextPosition equals the startPosition given in the Unity UI
    void Start()
    {
        nextPosition = startPosition.position;
    }

    // Using update as a way to loop postions that the block moves between 
    void Update()
    {
        if (transform.position == position1.position)
        {
            nextPosition = position2.position;
        }
        if (transform.position == position2.position)
        {
            nextPosition = position1.position;
        }
        transform.position = Vector3.MoveTowards(transform.position, nextPosition, speed * Time.deltaTime);
    }

    //When the character enters the object, they become teleported and the kill count increases
    //Kill count is increased
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (gameObject.name.ToUpper() != "Cube")
        {
            manMovement.man.transform.position = starter.transform.position;
            statCounter.kills++;
        }
    }
}
