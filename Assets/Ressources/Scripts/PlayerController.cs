using System.Collections;
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
    [SerializeField] private InputActionReference pauseMenuReference;
    [SerializeField] private float jumpForce = 500.0f;
    [SerializeField] private float sprintSpeed = 5.0f;

    public GameObject pauseMenu;

    private Rigidbody _body;
    private bool _sprinting = false;
    private bool _canJump = true;
    private bool _menu = false;


    void Start()
    {
        _body = GetComponent<Rigidbody>();
        pauseMenuReference.action.performed += PauseMenu;
        jumpActionReference.action.performed += OnJump;
        sprintActionReference.action.performed += OnSprint;
        sprintActionReference.action.canceled += OnSprint;
    }

    public void PauseMenu(InputAction.CallbackContext obj)
    {
        if (_menu)
        {
            _menu = false;
            pauseMenu.SetActive(false);
            Time.timeScale = 1;
            return;
        }
        Time.timeScale = 0;
        _menu = true;
        pauseMenu.SetActive(true);
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
