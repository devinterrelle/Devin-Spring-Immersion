using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;

    public float speedMultiplier = 5f;

    public float turnSpeedMultiplier = 10f;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
       float horizontalInput = Input.GetAxis("Horizontal");
       float verticalInput = Input.GetAxis("Vertical");
       
       Vector3 moveDirection = new Vector3 (horizontalInput, 0, verticalInput);

       if (moveDirection != Vector3.zero);
       {
        Quaternion targetrotation = Quaternion.LookRotation(moveDirection);

        transform.rotation = Quaternion.Slerp(transform.rotation, targetrotation, turnSpeedMultiplier * Time.deltaTime);

        controller.Move(moveDirection * speedMultiplier * Time.deltaTime);
       }
    }
}