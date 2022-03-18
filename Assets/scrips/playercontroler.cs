using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroler : MonoBehaviour
{
    private float speed = 20.0f;
    private float turnSpeed = 30.0f;
    private float horizontalInput;
    private Vector3 tankposition = new Vector3 (-2.7f, 5.73f, 10.2f);

    public GameObject ProjectailPrefab;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = tankposition;
    }

    // Update is called once per frame
    void Update()
    {
        

        horizontalInput = Input.GetAxis("Horizontal");

        transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime * horizontalInput);

        {
            transform.position = new Vector3( transform.position.y, transform.position.z);
        }     
        {
            transform.position = new Vector3( transform.position.y, transform.position.z);
        }

        if (Input.GetKeyDown(KeyCode.Space))

            Instantiate(ProjectailPrefab, transform.position, transform.rotation);
    }
}



