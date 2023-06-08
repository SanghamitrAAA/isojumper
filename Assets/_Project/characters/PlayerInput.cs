//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.5.1
//     from Assets/_Project/characters/PlayerInput.inputactions
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

public partial class @PlayerInput: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInput"",
    ""maps"": [
        {
            ""name"": ""CharacterControls"",
            ""id"": ""2a7c46fa-3da6-4e31-a4d9-2c5aea9c747f"",
            ""actions"": [
                {
                    ""name"": ""Jump"",
                    ""type"": ""Value"",
                    ""id"": ""ae9336ab-a368-42d9-9793-f3f999a94f0c"",
                    ""expectedControlType"": ""Vector3"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""FaceNorthEast"",
                    ""type"": ""Value"",
                    ""id"": ""8e6b3478-cd3b-4d21-9b71-b329df93b3aa"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""FaceNorthWest"",
                    ""type"": ""Value"",
                    ""id"": ""87cb6e3b-e957-4bff-a350-c5bd5d7f6fce"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""FaceSouthEast"",
                    ""type"": ""Value"",
                    ""id"": ""2e2644d0-f08f-4da4-a568-87bc8933d4b8"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""FaceSouthWest"",
                    ""type"": ""Value"",
                    ""id"": ""63bc8ba7-33e5-4c3f-8ee9-ab83d0afe017"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""38afdeec-3300-4188-9a91-9e32dd3dcaba"",
                    ""expectedControlType"": ""Vector3"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""08a9aae9-2b7d-4ea6-bb9d-f414c7b6fddb"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c92975ff-424b-4b00-9f3b-51347d02b990"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FaceNorthEast"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ec4cea2f-89c2-4984-9d1f-74ded6e5c0ef"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FaceNorthWest"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c539c6d8-494a-4b87-9a50-987674131cee"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FaceSouthEast"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""891f1bec-c67e-4253-91a3-362ff4755ad6"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FaceSouthWest"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""b973758f-38df-46e9-9691-809582ca976d"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""c1825439-afdf-479f-b5ab-e8746191baab"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""a1447d47-211d-43c9-b0cf-43ddb3928234"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""6927bb59-a6c0-466b-9472-8bbc1cb3537e"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""3815ff3c-e998-468a-8578-fbd0f244bf9b"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // CharacterControls
        m_CharacterControls = asset.FindActionMap("CharacterControls", throwIfNotFound: true);
        m_CharacterControls_Jump = m_CharacterControls.FindAction("Jump", throwIfNotFound: true);
        m_CharacterControls_FaceNorthEast = m_CharacterControls.FindAction("FaceNorthEast", throwIfNotFound: true);
        m_CharacterControls_FaceNorthWest = m_CharacterControls.FindAction("FaceNorthWest", throwIfNotFound: true);
        m_CharacterControls_FaceSouthEast = m_CharacterControls.FindAction("FaceSouthEast", throwIfNotFound: true);
        m_CharacterControls_FaceSouthWest = m_CharacterControls.FindAction("FaceSouthWest", throwIfNotFound: true);
        m_CharacterControls_Move = m_CharacterControls.FindAction("Move", throwIfNotFound: true);
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

    // CharacterControls
    private readonly InputActionMap m_CharacterControls;
    private List<ICharacterControlsActions> m_CharacterControlsActionsCallbackInterfaces = new List<ICharacterControlsActions>();
    private readonly InputAction m_CharacterControls_Jump;
    private readonly InputAction m_CharacterControls_FaceNorthEast;
    private readonly InputAction m_CharacterControls_FaceNorthWest;
    private readonly InputAction m_CharacterControls_FaceSouthEast;
    private readonly InputAction m_CharacterControls_FaceSouthWest;
    private readonly InputAction m_CharacterControls_Move;
    public struct CharacterControlsActions
    {
        private @PlayerInput m_Wrapper;
        public CharacterControlsActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Jump => m_Wrapper.m_CharacterControls_Jump;
        public InputAction @FaceNorthEast => m_Wrapper.m_CharacterControls_FaceNorthEast;
        public InputAction @FaceNorthWest => m_Wrapper.m_CharacterControls_FaceNorthWest;
        public InputAction @FaceSouthEast => m_Wrapper.m_CharacterControls_FaceSouthEast;
        public InputAction @FaceSouthWest => m_Wrapper.m_CharacterControls_FaceSouthWest;
        public InputAction @Move => m_Wrapper.m_CharacterControls_Move;
        public InputActionMap Get() { return m_Wrapper.m_CharacterControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CharacterControlsActions set) { return set.Get(); }
        public void AddCallbacks(ICharacterControlsActions instance)
        {
            if (instance == null || m_Wrapper.m_CharacterControlsActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_CharacterControlsActionsCallbackInterfaces.Add(instance);
            @Jump.started += instance.OnJump;
            @Jump.performed += instance.OnJump;
            @Jump.canceled += instance.OnJump;
            @FaceNorthEast.started += instance.OnFaceNorthEast;
            @FaceNorthEast.performed += instance.OnFaceNorthEast;
            @FaceNorthEast.canceled += instance.OnFaceNorthEast;
            @FaceNorthWest.started += instance.OnFaceNorthWest;
            @FaceNorthWest.performed += instance.OnFaceNorthWest;
            @FaceNorthWest.canceled += instance.OnFaceNorthWest;
            @FaceSouthEast.started += instance.OnFaceSouthEast;
            @FaceSouthEast.performed += instance.OnFaceSouthEast;
            @FaceSouthEast.canceled += instance.OnFaceSouthEast;
            @FaceSouthWest.started += instance.OnFaceSouthWest;
            @FaceSouthWest.performed += instance.OnFaceSouthWest;
            @FaceSouthWest.canceled += instance.OnFaceSouthWest;
            @Move.started += instance.OnMove;
            @Move.performed += instance.OnMove;
            @Move.canceled += instance.OnMove;
        }

        private void UnregisterCallbacks(ICharacterControlsActions instance)
        {
            @Jump.started -= instance.OnJump;
            @Jump.performed -= instance.OnJump;
            @Jump.canceled -= instance.OnJump;
            @FaceNorthEast.started -= instance.OnFaceNorthEast;
            @FaceNorthEast.performed -= instance.OnFaceNorthEast;
            @FaceNorthEast.canceled -= instance.OnFaceNorthEast;
            @FaceNorthWest.started -= instance.OnFaceNorthWest;
            @FaceNorthWest.performed -= instance.OnFaceNorthWest;
            @FaceNorthWest.canceled -= instance.OnFaceNorthWest;
            @FaceSouthEast.started -= instance.OnFaceSouthEast;
            @FaceSouthEast.performed -= instance.OnFaceSouthEast;
            @FaceSouthEast.canceled -= instance.OnFaceSouthEast;
            @FaceSouthWest.started -= instance.OnFaceSouthWest;
            @FaceSouthWest.performed -= instance.OnFaceSouthWest;
            @FaceSouthWest.canceled -= instance.OnFaceSouthWest;
            @Move.started -= instance.OnMove;
            @Move.performed -= instance.OnMove;
            @Move.canceled -= instance.OnMove;
        }

        public void RemoveCallbacks(ICharacterControlsActions instance)
        {
            if (m_Wrapper.m_CharacterControlsActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(ICharacterControlsActions instance)
        {
            foreach (var item in m_Wrapper.m_CharacterControlsActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_CharacterControlsActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public CharacterControlsActions @CharacterControls => new CharacterControlsActions(this);
    public interface ICharacterControlsActions
    {
        void OnJump(InputAction.CallbackContext context);
        void OnFaceNorthEast(InputAction.CallbackContext context);
        void OnFaceNorthWest(InputAction.CallbackContext context);
        void OnFaceSouthEast(InputAction.CallbackContext context);
        void OnFaceSouthWest(InputAction.CallbackContext context);
        void OnMove(InputAction.CallbackContext context);
    }
}
