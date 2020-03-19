using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float fallMultiplier = 2.5f;
    public float jumpVelocity = 10f;
    public float lowJumpMultiplier = 2f;
    public float movementForce = 4f;
    public float maxSpeed = 10f;
    public float jumpForce = 50f;
    public bool speedCapped = false;
    public GameManager manager;
    
    private Rigidbody2D rigidBody;
    private Transform transform;
    private bool jumped = false;
   
    void Awake()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        transform = GetComponent<Transform>();
    }
    void Update()
    {
        if (transform.position.y < 3) { manager.EndGame(); }
    }
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.A)) rigidBody.AddForce(new Vector2(-movementForce, 0), ForceMode2D.Impulse);

        else if (Input.GetKey(KeyCode.D)) rigidBody.AddForce(new Vector2(movementForce, 0), ForceMode2D.Impulse);


        if (speedCapped && (rigidBody.velocity.x > maxSpeed || rigidBody.velocity.x < -maxSpeed))
        {
            if(rigidBody.velocity.x > 0) rigidBody.velocity = new Vector2(maxSpeed, rigidBody.velocity.y);
            else rigidBody.velocity = new Vector2(-maxSpeed, rigidBody.velocity.y);
        }
        
        if (Input.GetKey(KeyCode.Space) && rigidBody.velocity.y >= 0 && jumped == false)
        {
            rigidBody.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
            if (!jumped) jumped = true;
        }

        if (rigidBody.velocity.y < 0)
        {
            rigidBody.velocity += Vector2.up * Physics2D.gravity.y * (fallMultiplier - 1) * Time.deltaTime;
        }
        else if (rigidBody.velocity.y > 0 && !Input.GetKey(KeyCode.Space))
        {
            rigidBody.velocity += Vector2.up * Physics2D.gravity.y * (lowJumpMultiplier - 1) * Time.deltaTime;
        }
    }

    public void ResetJump() { jumped = false; }
}
