
using UnityEngine;

public class FinishLine : MonoBehaviour
{

    public GameManager GameManager;

    public Player movement;

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Finish")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}