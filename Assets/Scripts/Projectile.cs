using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{

    public GameObject explosionEffect;

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        Vector3 particleSpawnPoint = other.transform.position;
        Instantiate(explosionEffect, particleSpawnPoint, Quaternion.identity);

        Destroy(other.gameObject);
    }
}
