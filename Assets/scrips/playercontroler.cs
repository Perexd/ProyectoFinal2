

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class playercontroler : MonoBehaviour
{
    private float movimiento;
    private float rotacion;
    public float movementspeed = 20f;
    public float rotationspeed = 80f;
    private int lives = 3;
    private int end = 0;
    public GameObject gameOver;
    public GameObject Win;
    public GameObject vidasxd;
    public TextMeshProUGUI Texto;

    // Start is called before the first frame update
    void Start()
    {
        gameOver.SetActive(false);
        Win.SetActive(false);
        vidasxd.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        movimiento = Input.GetAxis("Vertical");
        rotacion = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.forward * movementspeed * Time.deltaTime * movimiento);

        transform.Rotate(Vector3.up, rotationspeed * Time.deltaTime * rotacion);

       Texto.text = $"{lives}";
    }


    private void OnTriggerEnter(Collider otherCollider)
    {
        if (otherCollider.gameObject.CompareTag("Powerup"))
        {


            lives++;

            Debug.Log("tienes");

            end++;
            if (end == 5)
            {
                win();
            }

            Destroy(otherCollider.gameObject);

        }
        if (otherCollider.gameObject.CompareTag("misilenemigo"))
        {
            lives--;
            if (lives <= 0)
            {
                GameOver();
            }
            Destroy(otherCollider.gameObject);
        }
    }
    private void GameOver()
    {
        gameOver.SetActive(true);
        vidasxd.SetActive(false);
    }
    private void win()
    {
        Win.SetActive(true);
        vidasxd.SetActive(false);
    }

}