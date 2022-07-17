using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputReader : MonoBehaviour, InputMaster.IPlayerInputsActions

{

    private InputMaster PlayerInputs;

    public event Action LeftClickEvent;
    public event Action RightClickEvent;
    public event Action RightClickEventCanceled;

    private void Start()
    {
        PlayerInputs = new InputMaster();
        PlayerInputs.PlayerInputs.SetCallbacks(this);

        PlayerInputs.PlayerInputs.Enable();
    }

    private void OnDestroy()
    {
        
    }

    public void OnLeftClick(InputAction.CallbackContext context)
    {
        if (!context.performed) { return; }

        LeftClickEvent?.Invoke();
    }

    public void OnRightClick(InputAction.CallbackContext context)
    {

        if (!context.performed) { return; }

        RightClickEvent?.Invoke();
    }

    public void OnRightClickCancel(InputAction.CallbackContext context)
    {

        if (!context.canceled) { return; }

        RightClickEventCanceled?.Invoke();
    }

    public void OnWASD(InputAction.CallbackContext context)
    {
    }

    public void OnMouseRotation(InputAction.CallbackContext context)
    {
        
    }
}
