using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : Entity
{
    PlayerInput input;

    Vector2 movement;
    Vector2 mousePos;

    bool primaryPressed = false;

    Camera mainCam;
    Rigidbody2D rb;

    private void Awake()
    {
        input = new PlayerInput();

        input.Movement.Move.performed += ctx => movement = ctx.ReadValue<Vector2>();
        input.Movement.Move.canceled += ctx => movement = Vector2.zero;

        input.Attacks.Primary.performed += ctx => primaryPressed = true;
        input.Attacks.Primary.canceled += ctx => primaryPressed = false;

        input.Mouse.Pos.performed += ctx => mousePos = ctx.ReadValue<Vector2>();

        primaryCooldown = primaryCooldownTimer;
    }

    private void Start()
    {
        mainCam = Camera.main;
        rb = GetComponent<Rigidbody2D>();

        color = GetComponent<SpriteRenderer>().color;
    }

    private void Update()
    {
        if (primaryPressed) {
            Vector3 mouseInWorld = mainCam.ScreenToWorldPoint(mousePos);
            mouseInWorld.z = 0;

            Shoot(mouseInWorld, BulletController.BulletType.Player);
        }
    }

    private void FixedUpdate()
    {
        Move();
    }

    void Move()
    {
        rb.MovePosition(rb.position + movement * movementSpeed);
    }

    void EnableControls(bool enabled)
    {
        if (enabled)
        {
            input.Movement.Enable();
            input.Attacks.Enable();
            input.Mouse.Enable();
        } else
        {
            input.Movement.Disable();
            input.Attacks.Disable();
            input.Mouse.Disable();
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
