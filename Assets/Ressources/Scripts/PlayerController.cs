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
    private bool _canJump = true;


    void Start()
    {
        _body = GetComponent<Rigidbody>();
        jumpActionReference.action.performed += OnJump;
        sprintActionReference.action.performed += OnSprint;
        sprintActionReference.action.canceled += OnSprint;
    }
    

    private void OnJump(InputAction.CallbackContext obj)
    {
        if (!_canJump) return;
        _body.AddForce(Vector3.up * jumpForce);
        _canJump = false;
        StartCoroutine(DelayJump(0.7f));
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

    IEnumerator DelayJump(float delay)
    {
        yield return new WaitForSeconds(delay);
        _canJump = true;
    }
}
