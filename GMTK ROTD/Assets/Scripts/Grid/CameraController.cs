using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CameraController : MonoBehaviour
{
    Vector2 inputAxis;
    Vector3 moveDir;

    
    private float moveSpeed = 10f;

    Transform cam;

    InputMaster input;

    private float turnSmoothVelocity;
    private float rotationFactorPerFrame;

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

    private void Start()
    {
        cam = Camera.main.transform;
        Vector3 camF = cam.forward.normalized;
        Vector3 camR = cam.right.normalized;
    }
    // Start is called before the first frame update
    private void Update()
    {

        HandleRotation();
        transform.position += moveDir * moveSpeed * Time.deltaTime;
        

    }

    private void OnWASD(InputAction.CallbackContext context)
    {
        
        inputAxis = context.ReadValue<Vector2>();
        moveDir.x = inputAxis.x;
        moveDir.y = 0f;
        moveDir.z = inputAxis.y;

    }

    private void HandleRotation()
    {
        Vector3 positionToLookAt = new Vector3(inputAxis.x, 0f, inputAxis.y);

        float targetAngle = Mathf.Atan2(positionToLookAt.x, positionToLookAt.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
        float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, rotationFactorPerFrame);
        transform.rotation = Quaternion.Euler(0f, angle, 0f);
        
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
