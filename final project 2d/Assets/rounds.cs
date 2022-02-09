using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class rounds : MonoBehaviour
{
    public static int round = 1;
    public static int previousRounds;
    public Text roundCounter;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame

    //Keeps track of the rounds that the player go through
    void Update()
    {
        roundCounter.text = "Round: " + round.ToString();
        previousRounds = round;
    }
}
