using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public float movementSpeed = 8;

    PlayerInput input;
    Vector2 movement;

    private void Awake()
    {
        input = new PlayerInput();

        input.Movement.Move.performed += ctx => movement = ctx.ReadValue<Vector2>();
        input.Movement.Move.canceled += ctx => movement = Vector2.zero;
    }

    private void Update()
    {
        Move();
    }

    void Move()
    {
        transform.position += new Vector3(movement.x, movement.y, 0) * movementSpeed * Time.deltaTime;
    }

    void EnableControls(bool enabled)
    {
        if (enabled)
        {
            input.Movement.Enable();
        } else
        {
            input.Movement.Disable();
        }
    }

    private void OnEnable()
    {
        EnableControls(true);
    }
    private void OnDisable()
    {
        EnableControls(false);
    }
}
