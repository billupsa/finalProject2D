using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotations : MonoBehaviour
{

    public Transform center;
    public float Speed, Radius;
    private float x, y, z = 0;
    public Transform starter;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    //Using the position of a game object to calculate movement in a circle using x,y, and z coordinates

    // Update is called once per frame
    void Update()
    {
        x = center.position.x + Mathf.Cos(z) * Radius;
        y = center.position.y + Mathf.Sin(z) * Radius;
        transform.position = new Vector2(x, y);
        z = z + Time.deltaTime * Speed;

        if(z >= 360)
        {
            z = 0;
        }

    }

    //When the character enters the object, they become teleported and the kill count increases
    public void OnTriggerEnter2D(Collider2D collision)
    {
        manMovement.man.transform.position = starter.transform.position;
        statCounter.kills++;
    }
}
