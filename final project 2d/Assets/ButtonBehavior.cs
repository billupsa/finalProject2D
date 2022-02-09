using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonBehavior : MonoBehaviour
{
    // Start is called before the first frame update

    //When the button is pressed, the game is loaded; kills and rounds gets reset
    public void startGame()
    {
        SceneManager.LoadScene("SampleScene");
        statCounter.kills = 0;
        rounds.round = 1;

    }
}
