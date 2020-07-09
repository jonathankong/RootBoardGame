// GENERATED AUTOMATICALLY FROM 'Assets/Mouse Controls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @MouseControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @MouseControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Mouse Controls"",
    ""maps"": [
        {
            ""name"": ""Mouse"",
            ""id"": ""7b74f313-a104-43d0-bfb5-2677e206ecda"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""3605f6c5-8a72-462f-8b94-fdfadcbfeca0"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""PickUp"",
                    ""type"": ""Button"",
                    ""id"": ""0d572773-4819-4791-919a-d49ecc4ee518"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""bfcb39ad-6311-4eab-a555-d78148ee5c57"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b92cc5f4-c2db-4951-ad44-a70c0e6fb859"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": ""Hold"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PickUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Mouse
        m_Mouse = asset.FindActionMap("Mouse", throwIfNotFound: true);
        m_Mouse_Move = m_Mouse.FindAction("Move", throwIfNotFound: true);
        m_Mouse_PickUp = m_Mouse.FindAction("PickUp", throwIfNotFound: true);
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

    // Mouse
    private readonly InputActionMap m_Mouse;
    private IMouseActions m_MouseActionsCallbackInterface;
    private readonly InputAction m_Mouse_Move;
    private readonly InputAction m_Mouse_PickUp;
    public struct MouseActions
    {
        private @MouseControls m_Wrapper;
        public MouseActions(@MouseControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Mouse_Move;
        public InputAction @PickUp => m_Wrapper.m_Mouse_PickUp;
        public InputActionMap Get() { return m_Wrapper.m_Mouse; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MouseActions set) { return set.Get(); }
        public void SetCallbacks(IMouseActions instance)
        {
            if (m_Wrapper.m_MouseActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_MouseActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_MouseActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_MouseActionsCallbackInterface.OnMove;
                @PickUp.started -= m_Wrapper.m_MouseActionsCallbackInterface.OnPickUp;
                @PickUp.performed -= m_Wrapper.m_MouseActionsCallbackInterface.OnPickUp;
                @PickUp.canceled -= m_Wrapper.m_MouseActionsCallbackInterface.OnPickUp;
            }
            m_Wrapper.m_MouseActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @PickUp.started += instance.OnPickUp;
                @PickUp.performed += instance.OnPickUp;
                @PickUp.canceled += instance.OnPickUp;
            }
        }
    }
    public MouseActions @Mouse => new MouseActions(this);
    public interface IMouseActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnPickUp(InputAction.CallbackContext context);
    }
}
