using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMentScript : MonoBehaviour
{
    Vector3 movementInput;
    [SerializeField] float speed;

    private void Update()
    {
        Move();
    }
    private void Move()
    {
        Vector3 movement = Movement();

        transform.Translate(movement * speed * Time.deltaTime, Space.World);
    }

    private Vector3 Movement()
    {
        Vector3 movement = Vector3.zero;

        if (Input.GetKey(KeyCode.W))
        {
            movement.y++;
        }
        if (Input.GetKey(KeyCode.A))
        {
            movement.x--;
        }
        if (Input.GetKey(KeyCode.S))
        {
            movement.y--;
        }
        if (Input.GetKey(KeyCode.D))
        {
            movement.x++;
        }

        movement.Normalize();

        return movement;
    }
}
