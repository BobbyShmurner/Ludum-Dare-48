using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollower : MonoBehaviour
{
    [SerializeField] private Transform target;

    [SerializeField] private float lerpSpeed;

    private void Update()
    {
        Vector3 lerpPos = Vector3.Lerp(transform.position, target.position, lerpSpeed * Time.deltaTime);
        lerpPos.z = -10;

        transform.position = lerpPos;
    }
}
