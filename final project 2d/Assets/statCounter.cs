using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class statCounter : MonoBehaviour
{
    public static int kills = 0;
    public Text killCounter;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame

    //Keeps track of the kills that the player obtains
    //If the total amount of kills is 15 then the start screen is loaded
    void Update()
    {
        killCounter.text = "Deaths: " + kills.ToString();

        if(kills == 15)
        {
            SceneManager.LoadScene("StarterScreen");
        }
    }
}
