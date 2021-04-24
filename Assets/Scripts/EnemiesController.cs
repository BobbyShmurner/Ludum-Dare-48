using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class EnemiesController : Entity
{
    [SerializeField] private float nextWaypointDistance = 3;
    [SerializeField] private float shootingDistance = 5;

    [SerializeField] private LayerMask excludeFromGun;

    Path path;
    int currentWaypoint;
    bool reachedEndOfPath = false;

    Seeker seeker;
    Rigidbody2D rb;

    GameObject player;

    void Start()
    {
        primaryCooldown = primaryCooldownTimer;
        color = GetComponent<SpriteRenderer>().color;
        player = GameObject.FindGameObjectWithTag("Player");

        seeker = GetComponent<Seeker>();
        rb = GetComponent<Rigidbody2D>();

        InvokeRepeating("UpdatePath", 0f, .1f);
    }

    void UpdatePath()
    {
        if (seeker.IsDone()) seeker.StartPath(transform.position, player.transform.position, OnPathComplete);
    }

    void OnPathComplete(Path p)
    {
        if (!p.error)
        {
            path = p;
            currentWaypoint = 0;
        }
    }

    void Pathfind()
    {
        if (currentWaypoint >= path.vectorPath.Count)
        {
            reachedEndOfPath = true;
            return;
        } else
        {
            reachedEndOfPath = false;
        }

        float distance = Vector2.Distance(transform.position, path.vectorPath[currentWaypoint]);
        Vector3 direction = (transform.position - path.vectorPath[currentWaypoint]);
        transform.position = Vector3.Lerp(transform.position, new Vector3(path.vectorPath[currentWaypoint].x, path.vectorPath[currentWaypoint].y, 0) - direction.normalized * nextWaypointDistance, movementSpeed * Time.deltaTime);
        transform.position = new Vector3(transform.position.x, transform.position.y, 0);

        distance = Vector2.Distance(transform.position, path.vectorPath[currentWaypoint]);
        if (distance < nextWaypointDistance) { currentWaypoint++; }
    }

    void Update()
    {
        if (path != null) { Pathfind(); }

        RaycastHit2D hit = Physics2D.Raycast(transform.position, player.transform.position - transform.position, 25, ~excludeFromGun);
        if (hit.transform.gameObject == player) { Shoot(player.transform.position, BulletController.BulletType.Enemy); }

        print(hit.transform.gameObject);
    }
}
