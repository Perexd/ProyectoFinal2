using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bala: MonoBehaviour
{
    public float speed = 30f;
    [SerializeField] private float lifeTime = 5f;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, lifeTime);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
    private void OnTriggerEnter(Collider otherTrigger)
    {
        if (otherTrigger.gameObject.CompareTag("enemy"))
          {
            Destroy(gameObject);
          }  
    }
}