using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private ActionBasedContinuousMoveProvider moveProviderReference;
    [SerializeField] private InputActionReference jumpActionReference;
    [SerializeField] private InputActionReference sprintActionReference;
    [SerializeField] private float jumpForce = 500.0f;
    [SerializeField] private float sprintSpeed = 5.0f;

    private Rigidbody _body;
    private bool _sprinting = false;

    /* Cant jump outside starting zone, not yet sure why
    private bool IsGrounded => Physics.Raycast(
        new Vector2(transform.position.x, transform.position.y + 2.0f), Vector3.down, 2.0f); 
    */
    
    void Start()
    {
        _body = GetComponent<Rigidbody>();
        jumpActionReference.action.performed += OnJump;
        sprintActionReference.action.performed += OnSprint;
        sprintActionReference.action.canceled += OnSprint;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnJump(InputAction.CallbackContext obj)
    {
        //if (!IsGrounded) return;
        _body.AddForce(Vector3.up * jumpForce);
    }

    private void OnSprint(InputAction.CallbackContext obj)
    {
        if (!_sprinting)
        {
            moveProviderReference.moveSpeed = sprintSpeed;
            _sprinting = true;
        }
        else
        {
            moveProviderReference.moveSpeed = 2.0f;
            _sprinting = false;
        }

    }
}
