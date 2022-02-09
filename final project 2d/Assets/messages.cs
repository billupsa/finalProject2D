using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class messages : MonoBehaviour
{
    public Text message;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame

    //Messages that are displayed on canvas throughout the rounds(its based on the round) to give humor and direction
    void Update()
    {
        if (rounds.round == 1)
        {
            message.text = "Let's Play A Game";
        }
        else if (rounds.round == 2)
        {
            message.text = "One Block For Now";
        }
        else if (rounds.round == 3)
        {
            message.text = "No Pattern, You Say?";
        }
        else if (rounds.round == 4)
        {
            message.text = "You Know The Drill";
        }
        else if (rounds.round == 5)
        {
            message.text = "You Know The Drill Pt2";
        }
        else if (rounds.round == 6)
        {
            message.text = "Follow The North Star";
        }
        else if (rounds.round == 7)
        {
            message.text = "Is it really there?";
        }
    }
}
