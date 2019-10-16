using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogPlayerLocation : MonoBehaviour
{
    public GameObject[] players;

    // Start is called before the first frame update
    void Start()
    {
        players = GameObject.FindGameObjectsWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.N))
        {
            for (int i = 0; i< players.Length; i++)
            {
                Debug.Log("Player Number " + i + " is at " + players[i].transform.position);
            }
        }
        
    }
}
