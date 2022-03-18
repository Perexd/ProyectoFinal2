using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class misilenemigo : MonoBehaviour
  
{
    public GameObject misil;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawn", 2, 4);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void spawn()
    {
        Instantiate(misil, transform.position, transform.rotation);
    }
    private void OnTriggerEnter(Collider otherTrigger)
    {
        if (otherTrigger.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}
