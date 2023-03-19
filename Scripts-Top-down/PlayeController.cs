using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayeController : MonoBehaviour
{
    public float horizontalInput; // Breyta fyrir lárétt inntaks spilara.
    public float speed = 10.0f; // Hraði karakters þegar spilari hreyfir hann.
    public float xRange = 10.0f;

    public GameObject projectilePrefab;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        horizontalInput = Input.GetAxis("Horizontal"); // Tekur lárétt inntak og setur það í breytuna "horizontalInput"
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed); //Hreyfir player eftir inntak frá spilara
        if (Input.GetKeyDown(KeyCode.Space)) // Ef ýtt er space takka niður þá..... 
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}
