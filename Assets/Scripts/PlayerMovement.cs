using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private CharacterController controller;
    public float speed = 5f;
    public float crouchSpeed = 2.5f;
    public float jumpForce = 5f;
    public float gravity = 9.81f;
    private float verticalVelocity;
    public Transform cameraTransform;
    public float mouseSensitivity = 100f;
    private float xRotation = 0f;
    private bool isGrounded;
    private PhotonView photonview;
    private bool isCrouching = false;
    private float normalHeight;
    public float crouchHeight = 1f;
    private Animator animator;

    private void Awake()
    {
        photonview = GetComponent<PhotonView>();
    }

    void Start()
    {
        animator = GetComponent<Animator>();
        controller = GetComponent<CharacterController>();
        Cursor.lockState = CursorLockMode.Locked;
        normalHeight = controller.height;
    }

    void Update()
    {
        if (photonview.IsMine)
        {
            MovePlayer();
            RotateCamera();
            HandleCrouch();
        }
        else
        {
            cameraTransform.gameObject.GetComponent<Camera>().enabled = false;
        }
    }

    private void MovePlayer()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 0f, moveVertical);

        if (movement.magnitude > 1f)
        {
            movement.Normalize();
        }

        movement = cameraTransform.TransformDirection(movement);
        movement.y = 0f;

        isGrounded = controller.isGrounded;
        if (isGrounded && verticalVelocity < 0)
        {
            verticalVelocity = -2f;
        }

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            verticalVelocity = jumpForce;
            PlayerSoundManager.Instance.PlayJumpSound();
        }

        verticalVelocity -= gravity * Time.deltaTime;

        float currentSpeed = isCrouching ? crouchSpeed : speed;
        Vector3 velocity = movement * currentSpeed;
        velocity.y = verticalVelocity;

        controller.Move(velocity * Time.deltaTime);
    }

    private void RotateCamera()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        cameraTransform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        transform.Rotate(Vector3.up * mouseX);
    }

    private void HandleCrouch()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            isCrouching = true;
            animator.SetBool("sitting", true);
            controller.height = crouchHeight;
            controller.center = new Vector3(controller.center.x, crouchHeight / 2, controller.center.z);
        }
        else if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            if (!Physics.Raycast(transform.position, Vector3.up, normalHeight)) // Перевірка, чи є перешкода зверху
            {
                isCrouching = false;
                controller.height = normalHeight;
                controller.center = new Vector3(controller.center.x, normalHeight / 2, controller.center.z);
            }
        }
    }
}
