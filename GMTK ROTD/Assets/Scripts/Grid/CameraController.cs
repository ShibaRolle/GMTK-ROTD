using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CameraController : MonoBehaviour
{
    Vector2 inputAxis;
    Vector2 rotationVector;
    Vector3 rotation;
    Vector3 moveDir;
    private float moveSpeed = 10f;
  

    InputMaster input;
    private void Awake()
    {
        input = new InputMaster();

        input.PlayerInputs.WASD.performed += context =>
        {
            OnWASD(context);
        };
        input.PlayerInputs.WASD.canceled += context =>
        {
            OnWASD(context);
        };
    }
    // Start is called before the first frame update
    private void Update()
    {
        moveDir = transform.forward * inputAxis.y + transform.right * inputAxis.x;

        transform.position += moveDir * moveSpeed * Time.deltaTime;
        transform.eulerAngles += rotation * moveSpeed * Time.deltaTime;

    }

    private void OnWASD(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            inputAxis = context.ReadValue<Vector2>();
        }
        if (context.canceled)
        {
            inputAxis = new Vector2(0,0);
        }
        

    }

    private void OnEnable()
    {
        input.PlayerInputs.Enable();
    }
    private void OnDisable()
    {
        input.PlayerInputs.Disable();
    }


}
