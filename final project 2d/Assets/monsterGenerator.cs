using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monsterGenerator : MonoBehaviour
{
    public Transform spawnPoint;
    public Transform spawnPoint2;
    public Transform spawnPoint3;
    public GameObject orc;
    public static int totalMonsters;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        while (rounds.round <= 1000)
        {
            totalMonsters = rounds.round;

            for (int x =0; x< rounds.round;x++)
            {
                int pick = (int)Random.Range(1, 6);
                
                if (pick == 1)
                {
                    Instantiate(orc, spawnPoint);
                }
                if (pick == 2)
                {
                    Instantiate(orc, spawnPoint2);
                }
                if (pick == 3)
                {
                    Instantiate(orc, spawnPoint3);
                }
            }

            if(totalMonsters == 0)
            {
                rounds.round++;
            }
        }
    }
}
