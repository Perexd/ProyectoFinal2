using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class misilenemigo1 : MonoBehaviour
{
    public float speed = 20f;
    public float lifeTime = 5f;
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
      private void OnTriggerEnter(Collider otherCollider)
    {
        if (otherCollider.gameObject.CompareTag("player1"))
        {
          Destroy(gameObject);    
        }
    }
}