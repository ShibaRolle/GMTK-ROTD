using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CameraController : MonoBehaviour
{
    Vector2 inputAxis;
    Vector3 moveDir;

   

    [SerializeField] private CharacterController controller;
    
    private float moveSpeed = 10f;

    Transform cam;

    InputMaster input;

    private float turnSmoothVelocity;
    private float rotationFactorPerFrame = .1f;

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
        controller = GetComponent<CharacterController>();
        cam = Camera.main.transform;
        
    }
    // Start is called before the first frame update
    private void Update()
    {
        var forward = cam.transform.forward;
        var right = cam.transform.right;

        //project forward and right vectors on the horizontal plane (y = 0)
        forward.y = 0f;
        right.y = 0f;
        forward.Normalize();
        right.Normalize();

        //this is the direction in the world space we want to move:
        var desiredMoveDirection = forward * inputAxis.y + right * inputAxis.x;

        //now we can apply the movement:
        transform.Translate(desiredMoveDirection * moveSpeed * Time.deltaTime);

        //HandleRotation();
      

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
