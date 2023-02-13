using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    public float jumpForce;

    public CharacterController controller;

    private Vector3 moveDirection;
    void Start()
    {
        
    }

    void Update()
    {
        


        moveDirection = new Vector3(Input.GetAxis("Horizontal") * moveSpeed, 0f, Input.GetAxis("Vertical") * moveSpeed);

        if (Input.GetButtonDown("Jump"))
        {
            moveDirection.y = jumpForce;
        }

        controller.Move(moveDirection * Time.deltaTime);
    }
}
