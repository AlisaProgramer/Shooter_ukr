using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementHomework : MonoBehaviour
{
    public float speed = 5;
    private Rigidbody rb;
    public float jumpForce = 5f;
    public Vector3 scaleDirection;
    public float resizeSpeed = 1f;   
    public float speedStep = 0.1f;
    public bool changeX = true;
    public bool changeY = true;
    public bool changeZ = true;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void SetAxis()
    {
        scaleDirection = new Vector3(0,0,0);
        if (changeX)
        {
            scaleDirection.x = 1;
        }
        if (changeY)
        {
            scaleDirection.y = 1;
        }
        if (changeZ)
        {
            scaleDirection.z = 1;
        }
    }
    void Update()
    {
        SetAxis();
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Bigger();
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            Smaller();
        }
        if (Input.GetMouseButtonDown(0))
        {
            Jump();
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            BiggerV();
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            SmallerV();
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            changeX = !changeX;
        }
        if (Input.GetKeyDown(KeyCode.Z))
        {
            changeZ = !changeZ;
        }
        if (Input.GetKeyDown(KeyCode.Y))
        {
            changeY = !changeY;
        }
    }

    void Bigger()
    {
        Vector3 vec = scaleDirection * resizeSpeed / 1000;
        transform.localScale += vec;
    }
    void Smaller()
    {
        Vector3 vec = scaleDirection * resizeSpeed / 1000;
        transform.localScale -= vec;
    }
    void Jump()
    {
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);   
    }
    void BiggerV()
    {
        resizeSpeed += speedStep;
    }
    void SmallerV()
    {
        resizeSpeed = Mathf.Max(0, resizeSpeed - speedStep);
    }
    
}
