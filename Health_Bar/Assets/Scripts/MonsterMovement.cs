using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterMovement : MonoBehaviour
{
    public float movementSpeed = 1;
    public float maximumDisplacement = 10;

    private float startPositionH;
    private float endPositionH;

    private Transform transform;
    void Awake()
    {
        transform = GetComponent<Transform>();
        startPositionH = transform.position.x;
        endPositionH = transform.position.x + maximumDisplacement;
        //Debug.Log(startPositionH + ", " + endPositionH);
    }
    void Update()
    {
        if (transform.position.x > endPositionH || transform.position.x < startPositionH) movementSpeed = -movementSpeed;

        transform.position = new Vector2(transform.position.x + movementSpeed * Time.deltaTime, transform.position.y);
        //Debug.Log(movementSpeed);

    }
}
