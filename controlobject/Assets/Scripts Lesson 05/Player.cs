using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class Player : MonoBehaviour
{
    private CharacterController characterController;
    [SerializeField] private float speed;

    private void Start()
    {
        characterController = GetComponent<CharacterController>();

    }

    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 moveDirection = new Vector3(horizontalInput, 0f, verticalInput);

        moveDirection = transform.TransformDirection(moveDirection);

        moveDirection *= speed;

        if (characterController.isGrounded)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                // Xử lý phần nhảy
            }
        }
        // xử lý phần di chuyển
        characterController.Move(moveDirection * Time.deltaTime);
    }
}
