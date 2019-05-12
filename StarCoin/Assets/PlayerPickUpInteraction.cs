using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPickUpInteraction : MonoBehaviour
{
    [SerializeField]
    private GameScore gameScore;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("PickUp"); // Срабатывает


        if (collision.gameObject.tag == "Heart")  //collision.gameObject.tag == \"Heart\"
        {
            Debug.Log("Heart");
            gameScore.AddScore();
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.tag == "Bomb")
        {
            Debug.Log("Bomb");
            gameScore.SubtractScore();
            Destroy(collision.gameObject);
        }
    }
}
