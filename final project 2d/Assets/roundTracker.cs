using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class roundTracker : MonoBehaviour
{
    public Text previousRound;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame

    //Used to track the previous round that the player played on
    //Used for starter screen
    void Update()
    {
        previousRound.text = "Previous Round: " + rounds.previousRounds.ToString();
    }
}
