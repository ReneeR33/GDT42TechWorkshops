using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private PlayerMovement playerMovement;
    private void Awake()
    {
        playerMovement = GetComponent<PlayerMovement>();
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        playerMovement.ResetJump();

        if (collision.collider.tag == "Spike")
        {
            Debug.Log("Game over");
            playerMovement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
        else if (collision.collider.tag == "Monster")
        {
            GetComponent<Health>().Damage(30);
        }

    }
    
}
