using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy: MonoBehaviour
{
    private Rigidbody enemyRigidbody;
    private GameObject player;
    [SerializeField] private float speed = 1;

    private void Start()
    {
        enemyRigidbody = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
    }

    void Update()
    {
        Vector3 direction = (player.transform.position - transform.position).normalized;
        enemyRigidbody.AddForce(direction * speed);

       transform.LookAt(player.transform.position);
    }

        private void OnCollisionEnter (Collision otherColider)
    {
        if (otherColider.gameObject.CompareTag("bala"))
        {
            Destroy(gameObject);
        }
    }
    private void fixedUpdate()
    {
    enemyRigidbody.AddForce((player.transform.position - transform.position).normalized * speed * Time.deltaTime);
    }
}