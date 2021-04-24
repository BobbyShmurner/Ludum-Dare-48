using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    [SerializeField] private float speed = 10;
    public int damage = 10;

    [HideInInspector] public BulletType bulletType;

    public enum BulletType
    {
        Player,
        Enemy
    }

    private void Start()
    {
        StartCoroutine(DeleteAutomatically());
    }

    void LateUpdate()
    {
        transform.position += transform.up * Time.deltaTime * speed;
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Player") && bulletType == BulletType.Player) { return; }
        if (collider.CompareTag("Enemy") && bulletType == BulletType.Enemy) { return; }

        Entity entity = collider.GetComponent<Entity>();

        if (entity) {
            entity.health -= damage;
            
            if (entity.health <= 0)
            {
                Destroy(entity.gameObject);
            }
        }

        Destroy(gameObject);
    }

    IEnumerator DeleteAutomatically()
    {
        yield return new WaitForSeconds(3);
        Destroy(gameObject);
    }
}
