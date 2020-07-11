using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]
    private float movementSpeed;

    // Start is called before the first frame update
    void Start()
    {

    }
    
    // Update is called once per frame
    void Update()
    {
        // going right
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(1, 0, 0) * Time.deltaTime * movementSpeed;
        }

        // going left
        else if (Input.GetKey(KeyCode.A))
        {
            transform.position -= new Vector3(1, 0, 0) * Time.deltaTime * movementSpeed;
        }

        // going upwards
        else if (Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(0, 0, 1) * Time.deltaTime * movementSpeed;
        }

        // going backwards
        else if (Input.GetKey(KeyCode.S))
        {
            transform.position -= new Vector3(0, 0, 1) * Time.deltaTime * movementSpeed;
        }
    }
}
