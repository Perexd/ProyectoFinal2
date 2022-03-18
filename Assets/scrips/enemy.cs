using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy: MonoBehaviour
{
    private Rigidbody enemyRigidbody;
    private GameObject player;
    [SerializeField] private float speed = 2;

    private void Start()
    {
      
    }

    void Update()
    {
        Vector3 direction = (player.transform.position - transform.position).normalized;
        enemyRigidbody.AddForce(direction * speed);
    }

        private void OnCollisionEnter (Collision otherColider)
    {
        if (otherColider.gameObject.CompareTag("bala"))
        {
            Destroy(gameObject);
        }
    }
}