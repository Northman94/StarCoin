using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOutOfBorders : MonoBehaviour 
{
    [SerializeField]
    private GameScore gameScore;

    [SerializeField]
    private GameObject player;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Restart");
            gameScore.RestartGame();
        }
    }
}
