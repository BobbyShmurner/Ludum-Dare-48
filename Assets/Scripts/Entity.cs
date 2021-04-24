using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entity : MonoBehaviour
{
    [SerializeField] protected float movementSpeed = 0.15f;

    public int health = 100;

    [SerializeField] protected float primaryCooldownTimer = 0.2f;
    [SerializeField] protected float accuracyOffset = 1f;

    [SerializeField] protected GameObject bullet;

    protected float primaryCooldown = 0.0f;
    protected  Vector4 color;

    protected void Shoot(Vector3 target, BulletController.BulletType type)
    {
        if (primaryCooldown > 0)
        {
            primaryCooldown -= Time.deltaTime;
            return;
        }

        GameObject bulletObj = Instantiate(bullet);
        bulletObj.transform.position = transform.position;

        bulletObj.GetComponent<BulletController>().bulletType = type;
        bulletObj.GetComponent<SpriteRenderer>().color = color;

        Vector3 dir = new Vector3(target.x, target.y, 0) - (transform.position + new Vector3(Random.Range(-accuracyOffset, accuracyOffset), Random.Range(-accuracyOffset, accuracyOffset), 0));

        bulletObj.transform.up = dir;

        primaryCooldown = primaryCooldownTimer;
    }
}
