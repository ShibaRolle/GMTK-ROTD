using Cinemachine;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(CinemachineVirtualCamera))]
public class CinemachineVcam : MonoBehaviour
{
    private InputMaster playerInputActions;

    private bool moveCam;

    private CinemachineVirtualCamera cinemachineVirtualCamera;

    [field: SerializeField] private InputReader input;

    Vector2 camLook;
    Vector3 camZoom;
    Vector2 newPosition;

    private void Awake()
    {
        input.RightClickEvent += rightclick;
        input.RightClickEventCanceled += rightclickcancel;
        playerInputActions = new InputMaster();

        Camera.main.gameObject.TryGetComponent<CinemachineBrain>(out var brain);
        if (brain == null)
        {
            brain = Camera.main.gameObject.AddComponent<CinemachineBrain>();
        }

        cinemachineVirtualCamera = gameObject.GetComponent<CinemachineVirtualCamera>();

        playerInputActions.Look.Mouse.performed += ctx =>
        {
            OnCamMoveInput(ctx);
        };

        playerInputActions.Look.Mouse.canceled += ctx =>
        {
            OnCamMoveInput(ctx);
        };

        playerInputActions.Look.Zoom.performed += ctx =>
        {
            OnCamZoomInput(ctx);
        };

        playerInputActions.Look.Zoom.canceled += ctx =>
        {
            OnCamZoomInput(ctx);
        };
     
    }

    private void Update()
    {

        if (moveCam)
        {
            newPosition.y += camLook.x;
            newPosition.x += -camLook.y;

            if (newPosition.x >= 85)
            {
                newPosition.x = 85;
            }

            if (newPosition.x <= 12)
            {
                newPosition.x = 12;
            }

            
            transform.localRotation = Quaternion.Euler(newPosition);
        }

        HandleZoom();
    }

    void OnCamMoveInput(InputAction.CallbackContext context)
    {
        camLook = context.ReadValue<Vector2>();
    }
    void OnCamZoomInput(InputAction.CallbackContext context)
    {
        camZoom = context.ReadValue<Vector2>();
    }

    private void rightclick()
    {
        moveCam = true;
    }
    private void rightclickcancel()
    {
        moveCam = false;
    }

    void HandleZoom()
    {
        CinemachineComponentBase componentBase = cinemachineVirtualCamera.GetCinemachineComponent(CinemachineCore.Stage.Body);
 
        camZoom = camZoom.normalized;

        if ((componentBase as CinemachineFramingTransposer).m_CameraDistance >= 15)
        {
            (componentBase as CinemachineFramingTransposer).m_CameraDistance = 15;
        }
        else if((componentBase as CinemachineFramingTransposer).m_CameraDistance <= 2)
        {
            (componentBase as CinemachineFramingTransposer).m_CameraDistance = 2;
        }
        
        if (componentBase is CinemachineFramingTransposer)
        {
            (componentBase as CinemachineFramingTransposer).m_CameraDistance += -camZoom.y; // your value
        }
    }

    private void OnEnable()
    {
        playerInputActions.Look.Enable();
    }

    private void OnDisable()
    {
        playerInputActions.Look.Disable();
    }
}
