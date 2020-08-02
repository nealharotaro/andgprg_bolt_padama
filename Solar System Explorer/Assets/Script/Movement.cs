using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]
    private float movementSpeed;
    [SerializeField]
    private float rotationSpeed;

    // Start is called before the first frame update
    void Start()
    {

    }
    
    // Update is called once per frame
    void Update()
    {
        // Changed control navigations to: QE -> rotation, WASD -> Movement
        // going right
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += transform.right * Time.deltaTime * movementSpeed;
        }

        // going left
        else if (Input.GetKey(KeyCode.A))
        {
            transform.position -= transform.right * Time.deltaTime * movementSpeed;
        }

        // going forward
        else if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * Time.deltaTime * movementSpeed;
        }

        // going backwards
        else if (Input.GetKey(KeyCode.S))
        {
            transform.position -= transform.forward * Time.deltaTime * movementSpeed;
        }
        
        //rotating towards left
        else if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(-Vector3.up * rotationSpeed * Time.deltaTime);
        }

        //rotating towards right
        else if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
        }
    }
}
