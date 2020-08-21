using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]
    private float movementSpeed;

    private float width;
    private float right;
    private float left;

    // Start is called before the first frame update
    void Start()
    {
        width = Camera.main.orthographicSize * Camera.main.aspect;
        right = (width + Camera.main.transform.position.x) * 2;
        left = (Camera.main.transform.position.x - width) * 2;
    }
    
    void Move()  // changed navigations with only AD and -> <- keys
    {
            // going right
            if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            {
                transform.position += transform.right * Time.deltaTime * movementSpeed;
                // clamping the bounds within camera frame
                if(transform.position.x > right)
                {
                    transform.position = new Vector3(right, transform.position.y, transform.position.z);
                }
            }
        {
            // going left
            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            {
                transform.position -= transform.right * Time.deltaTime * movementSpeed;
                // clamping the bounds within camera frame
                if(transform.position.x < left)
                {
                    transform.position = new Vector3(left, transform.position.y, transform.position.z);
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
}
