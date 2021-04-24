using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    [SerializeField] private float speed = 10;

    private void Start()
    {
        StartCoroutine(DeleteAutomatically());
    }

    void Update()
    {
        transform.position += transform.up * Time.deltaTime * speed;
    }

    IEnumerator DeleteAutomatically()
    {
        yield return new WaitForSeconds(3);
        Destroy(gameObject);
    }
}
