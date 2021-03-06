//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/InputMaster.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @InputMaster : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputMaster()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputMaster"",
    ""maps"": [
        {
            ""name"": ""PlayerInputs"",
            ""id"": ""8bc00f11-aa78-4e53-a489-62a4ef2bed13"",
            ""actions"": [
                {
                    ""name"": ""LeftClick"",
                    ""type"": ""Button"",
                    ""id"": ""37b815a3-d816-40f8-b450-1a9973d7e55c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""RightClick"",
                    ""type"": ""Button"",
                    ""id"": ""c7e5447f-116c-4372-b9f6-fc8d063d9674"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""WASD"",
                    ""type"": ""Value"",
                    ""id"": ""b57ceeea-6d48-4713-99ac-040f0fd708c1"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": ""NormalizeVector2"",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""RightClickCancel"",
                    ""type"": ""Button"",
                    ""id"": ""e84d453a-140e-4a36-9bed-99d01be6d576"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""eb1e68f9-a273-4af1-96bc-c640460d0f87"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""23c21a50-bc0d-4239-81c1-737609bd9638"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""024db3a6-4cad-4fad-8d64-620d1b830661"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WASD"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""e6b04130-0472-4ab9-919f-b683a5fc2462"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WASD"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""5842f4b4-6820-4599-9ca4-4797a0125e74"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WASD"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""eeb8b060-f5be-4fc7-b038-f6991977f4e6"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WASD"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""e30fd4a7-47b4-41fb-b623-ccb13ee2fbbd"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WASD"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""844b9cd8-3ef4-4ade-98f7-0afe7862f78e"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightClickCancel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Look"",
            ""id"": ""4d6f9506-4dcd-4e85-b62c-0e79b5758be6"",
            ""actions"": [
                {
                    ""name"": ""Mouse"",
                    ""type"": ""Value"",
                    ""id"": ""753c640a-510e-44ad-9179-5d63784eb795"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Zoom"",
                    ""type"": ""Value"",
                    ""id"": ""77d705bc-0e15-488c-b26c-f5101878949a"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""0a58b6b7-a2aa-46e5-9574-1f3f392b33e7"",
                    ""path"": ""<Mouse>/Delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Mouse"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""485b6170-d339-44af-819d-c2526fcc6c17"",
                    ""path"": ""<Mouse>/scroll"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Zoom"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // PlayerInputs
        m_PlayerInputs = asset.FindActionMap("PlayerInputs", throwIfNotFound: true);
        m_PlayerInputs_LeftClick = m_PlayerInputs.FindAction("LeftClick", throwIfNotFound: true);
        m_PlayerInputs_RightClick = m_PlayerInputs.FindAction("RightClick", throwIfNotFound: true);
        m_PlayerInputs_WASD = m_PlayerInputs.FindAction("WASD", throwIfNotFound: true);
        m_PlayerInputs_RightClickCancel = m_PlayerInputs.FindAction("RightClickCancel", throwIfNotFound: true);
        // Look
        m_Look = asset.FindActionMap("Look", throwIfNotFound: true);
        m_Look_Mouse = m_Look.FindAction("Mouse", throwIfNotFound: true);
        m_Look_Zoom = m_Look.FindAction("Zoom", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // PlayerInputs
    private readonly InputActionMap m_PlayerInputs;
    private IPlayerInputsActions m_PlayerInputsActionsCallbackInterface;
    private readonly InputAction m_PlayerInputs_LeftClick;
    private readonly InputAction m_PlayerInputs_RightClick;
    private readonly InputAction m_PlayerInputs_WASD;
    private readonly InputAction m_PlayerInputs_RightClickCancel;
    public struct PlayerInputsActions
    {
        private @InputMaster m_Wrapper;
        public PlayerInputsActions(@InputMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @LeftClick => m_Wrapper.m_PlayerInputs_LeftClick;
        public InputAction @RightClick => m_Wrapper.m_PlayerInputs_RightClick;
        public InputAction @WASD => m_Wrapper.m_PlayerInputs_WASD;
        public InputAction @RightClickCancel => m_Wrapper.m_PlayerInputs_RightClickCancel;
        public InputActionMap Get() { return m_Wrapper.m_PlayerInputs; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerInputsActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerInputsActions instance)
        {
            if (m_Wrapper.m_PlayerInputsActionsCallbackInterface != null)
            {
                @LeftClick.started -= m_Wrapper.m_PlayerInputsActionsCallbackInterface.OnLeftClick;
                @LeftClick.performed -= m_Wrapper.m_PlayerInputsActionsCallbackInterface.OnLeftClick;
                @LeftClick.canceled -= m_Wrapper.m_PlayerInputsActionsCallbackInterface.OnLeftClick;
                @RightClick.started -= m_Wrapper.m_PlayerInputsActionsCallbackInterface.OnRightClick;
                @RightClick.performed -= m_Wrapper.m_PlayerInputsActionsCallbackInterface.OnRightClick;
                @RightClick.canceled -= m_Wrapper.m_PlayerInputsActionsCallbackInterface.OnRightClick;
                @WASD.started -= m_Wrapper.m_PlayerInputsActionsCallbackInterface.OnWASD;
                @WASD.performed -= m_Wrapper.m_PlayerInputsActionsCallbackInterface.OnWASD;
                @WASD.canceled -= m_Wrapper.m_PlayerInputsActionsCallbackInterface.OnWASD;
                @RightClickCancel.started -= m_Wrapper.m_PlayerInputsActionsCallbackInterface.OnRightClickCancel;
                @RightClickCancel.performed -= m_Wrapper.m_PlayerInputsActionsCallbackInterface.OnRightClickCancel;
                @RightClickCancel.canceled -= m_Wrapper.m_PlayerInputsActionsCallbackInterface.OnRightClickCancel;
            }
            m_Wrapper.m_PlayerInputsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @LeftClick.started += instance.OnLeftClick;
                @LeftClick.performed += instance.OnLeftClick;
                @LeftClick.canceled += instance.OnLeftClick;
                @RightClick.started += instance.OnRightClick;
                @RightClick.performed += instance.OnRightClick;
                @RightClick.canceled += instance.OnRightClick;
                @WASD.started += instance.OnWASD;
                @WASD.performed += instance.OnWASD;
                @WASD.canceled += instance.OnWASD;
                @RightClickCancel.started += instance.OnRightClickCancel;
                @RightClickCancel.performed += instance.OnRightClickCancel;
                @RightClickCancel.canceled += instance.OnRightClickCancel;
            }
        }
    }
    public PlayerInputsActions @PlayerInputs => new PlayerInputsActions(this);

    // Look
    private readonly InputActionMap m_Look;
    private ILookActions m_LookActionsCallbackInterface;
    private readonly InputAction m_Look_Mouse;
    private readonly InputAction m_Look_Zoom;
    public struct LookActions
    {
        private @InputMaster m_Wrapper;
        public LookActions(@InputMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @Mouse => m_Wrapper.m_Look_Mouse;
        public InputAction @Zoom => m_Wrapper.m_Look_Zoom;
        public InputActionMap Get() { return m_Wrapper.m_Look; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(LookActions set) { return set.Get(); }
        public void SetCallbacks(ILookActions instance)
        {
            if (m_Wrapper.m_LookActionsCallbackInterface != null)
            {
                @Mouse.started -= m_Wrapper.m_LookActionsCallbackInterface.OnMouse;
                @Mouse.performed -= m_Wrapper.m_LookActionsCallbackInterface.OnMouse;
                @Mouse.canceled -= m_Wrapper.m_LookActionsCallbackInterface.OnMouse;
                @Zoom.started -= m_Wrapper.m_LookActionsCallbackInterface.OnZoom;
                @Zoom.performed -= m_Wrapper.m_LookActionsCallbackInterface.OnZoom;
                @Zoom.canceled -= m_Wrapper.m_LookActionsCallbackInterface.OnZoom;
            }
            m_Wrapper.m_LookActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Mouse.started += instance.OnMouse;
                @Mouse.performed += instance.OnMouse;
                @Mouse.canceled += instance.OnMouse;
                @Zoom.started += instance.OnZoom;
                @Zoom.performed += instance.OnZoom;
                @Zoom.canceled += instance.OnZoom;
            }
        }
    }
    public LookActions @Look => new LookActions(this);
    public interface IPlayerInputsActions
    {
        void OnLeftClick(InputAction.CallbackContext context);
        void OnRightClick(InputAction.CallbackContext context);
        void OnWASD(InputAction.CallbackContext context);
        void OnRightClickCancel(InputAction.CallbackContext context);
    }
    public interface ILookActions
    {
        void OnMouse(InputAction.CallbackContext context);
        void OnZoom(InputAction.CallbackContext context);
    }
}
