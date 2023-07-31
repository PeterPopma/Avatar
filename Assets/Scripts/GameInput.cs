using Cinemachine;
using UnityEngine;
using UnityEngine.InputSystem;

public class GameInput : MonoBehaviour
{
    CinemachineVirtualCamera vcamMainCamera;

    private float yaw = 0f;
    private float pitch = 0f;
    
    [SerializeField]
    private float moveByKeySpeed = 4f;
    
    [SerializeField]
    private float lookSpeed = 2f;

    [SerializeField]
    private float zoomSpeed = 2f;

    private bool buttonCameraForward;
    private bool buttonCameraBack;
    private bool buttonCameraLeft;
    private bool buttonCameraRight;
    private bool buttonCameraUp;
    private bool buttonCameraDown;
    private bool buttonCameraLookAround;
    private Vector2 look;
    private float timeMovingStarted;

    public void Start()
    {
        vcamMainCamera = GetComponent<CinemachineVirtualCamera>();
    }

    private void OnLook(InputValue value)
    {
        look = value.Get<Vector2>();
    }

    private void OnCameraForward(InputValue value)
    {
        timeMovingStarted = Time.time;
        buttonCameraForward = value.isPressed;
    }

    private void OnCameraBack(InputValue value)
    {
        timeMovingStarted = Time.time;
        buttonCameraBack = value.isPressed;
    }

    private void OnCameraLeft(InputValue value)
    {
        timeMovingStarted = Time.time;
        buttonCameraLeft = value.isPressed;
    }

    private void OnCameraRight(InputValue value)
    {
        timeMovingStarted = Time.time;
        buttonCameraRight = value.isPressed;
    }

    private void OnCameraUp(InputValue value)
    {
        timeMovingStarted = Time.time;
        buttonCameraUp = value.isPressed;
    }

    private void OnCameraDown(InputValue value)
    {
        timeMovingStarted = Time.time;
        buttonCameraDown = value.isPressed;
    }

    private void OnCameraLookAround(InputValue value)
    {
        buttonCameraLookAround = value.isPressed;
    }

    private void Update()
    {
        float moveSpeed = moveByKeySpeed * Mathf.Pow(2, (Time.time - timeMovingStarted));

        if (buttonCameraForward)
        {
            transform.position += transform.forward * Time.deltaTime * moveSpeed;
        }
        if (buttonCameraBack)
        {
            transform.position -= transform.forward * Time.deltaTime * moveSpeed;
        }
        if (buttonCameraRight)
        {
            transform.position += transform.right * Time.deltaTime * moveSpeed;
        }
        if (buttonCameraLeft)
        {
            transform.position -= transform.right * Time.deltaTime * moveSpeed;
        }
        if (buttonCameraUp)
        {
            transform.position += transform.up * Time.deltaTime * moveSpeed;
        }
        if (buttonCameraDown)
        {
            transform.position -= transform.up * Time.deltaTime * moveSpeed;
        }

        // Look around when right mouse is pressed
        if (buttonCameraLookAround)
        {
            yaw += lookSpeed * look.x;
            pitch -= lookSpeed * look.y;

            vcamMainCamera.transform.eulerAngles = new Vector3(pitch, yaw, 0f);
        }

    }
}