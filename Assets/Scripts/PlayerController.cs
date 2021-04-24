using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float movementSpeed = 8;
    [SerializeField] private float primaryCooldownTimer = 0.2f;

    public GameObject bullet;

    PlayerInput input;

    Vector2 movement;
    Vector2 mousePos;

    bool primaryPressed = false;
    float primaryCooldown = 0.0f;

    Camera mainCam;

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
    }

    private void Update()
    {
        Move();
        Shoot();
    }

    void Move()
    {
        transform.position += new Vector3(movement.x, movement.y, 0) * movementSpeed * Time.deltaTime;
    }

    void Shoot()
    {
        if (primaryCooldown > 0)
        {
            primaryCooldown -= Time.deltaTime;
            return;
        }

        if (!primaryPressed) { return; }
        GameObject bulletObj = Instantiate(bullet);
        bulletObj.transform.position = transform.position;

        Vector3 mouseInWorld = mainCam.ScreenToWorldPoint(mousePos);
        mouseInWorld.z = 0;

        Vector3 dir = mouseInWorld - transform.position;

        bulletObj.transform.up = dir;

        primaryCooldown = primaryCooldownTimer;
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
