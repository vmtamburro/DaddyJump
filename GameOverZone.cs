using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverZone : MonoBehaviour
{
    public GameManager gameManager;
    private void OnTriggerEnter2D(Collider2D collision)
    {       

        if(collision.tag == "Player")
        {
            gameManager.EndGame();
        }
    }
}
