// GENERATED AUTOMATICALLY FROM 'Assets/PlayerInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInput : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInput"",
    ""maps"": [
        {
            ""name"": ""Movement"",
            ""id"": ""2dd0e61c-fbfc-4800-b20c-5faa45c00844"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Button"",
                    ""id"": ""c2e28094-5c77-4b53-874c-3fb7bc9c0fd7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""634faca0-3997-43fe-8f4e-129a38c5cb56"",
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
                    ""id"": ""e298162c-e8b3-4714-b179-8ff148949746"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""da6b80dd-10ee-4525-a11d-e0504c9b7298"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""9341b887-bf33-4eb0-9f9d-e2e80f60dfd9"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""d2e6f117-9399-4620-b442-18e969464964"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""Attacks"",
            ""id"": ""e1f1e719-91cd-494f-b7ee-7b1cd301320a"",
            ""actions"": [
                {
                    ""name"": ""Primary"",
                    ""type"": ""Value"",
                    ""id"": ""24cfeb02-27cf-4f05-8299-7782fdb05418"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""0288bee6-5f02-470f-94cf-e3e28622ed54"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""Primary"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Mouse"",
            ""id"": ""6271710b-539b-4136-b3d4-a56df3479bfd"",
            ""actions"": [
                {
                    ""name"": ""Pos"",
                    ""type"": ""PassThrough"",
                    ""id"": ""4805853d-e8eb-4645-a0b9-c7497d3ef351"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Delta"",
                    ""type"": ""PassThrough"",
                    ""id"": ""441b1299-1447-4844-a0be-1328a5e36f78"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""70bc97f6-272f-42cb-a02c-883f6c8d766d"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""Pos"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a4d7215b-8b0f-4074-9d78-5d56a4e9e5d8"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""Delta"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""PC"",
            ""bindingGroup"": ""PC"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Movement
        m_Movement = asset.FindActionMap("Movement", throwIfNotFound: true);
        m_Movement_Move = m_Movement.FindAction("Move", throwIfNotFound: true);
        // Attacks
        m_Attacks = asset.FindActionMap("Attacks", throwIfNotFound: true);
        m_Attacks_Primary = m_Attacks.FindAction("Primary", throwIfNotFound: true);
        // Mouse
        m_Mouse = asset.FindActionMap("Mouse", throwIfNotFound: true);
        m_Mouse_Pos = m_Mouse.FindAction("Pos", throwIfNotFound: true);
        m_Mouse_Delta = m_Mouse.FindAction("Delta", throwIfNotFound: true);
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

    // Movement
    private readonly InputActionMap m_Movement;
    private IMovementActions m_MovementActionsCallbackInterface;
    private readonly InputAction m_Movement_Move;
    public struct MovementActions
    {
        private @PlayerInput m_Wrapper;
        public MovementActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Movement_Move;
        public InputActionMap Get() { return m_Wrapper.m_Movement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MovementActions set) { return set.Get(); }
        public void SetCallbacks(IMovementActions instance)
        {
            if (m_Wrapper.m_MovementActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnMove;
            }
            m_Wrapper.m_MovementActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
            }
        }
    }
    public MovementActions @Movement => new MovementActions(this);

    // Attacks
    private readonly InputActionMap m_Attacks;
    private IAttacksActions m_AttacksActionsCallbackInterface;
    private readonly InputAction m_Attacks_Primary;
    public struct AttacksActions
    {
        private @PlayerInput m_Wrapper;
        public AttacksActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Primary => m_Wrapper.m_Attacks_Primary;
        public InputActionMap Get() { return m_Wrapper.m_Attacks; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(AttacksActions set) { return set.Get(); }
        public void SetCallbacks(IAttacksActions instance)
        {
            if (m_Wrapper.m_AttacksActionsCallbackInterface != null)
            {
                @Primary.started -= m_Wrapper.m_AttacksActionsCallbackInterface.OnPrimary;
                @Primary.performed -= m_Wrapper.m_AttacksActionsCallbackInterface.OnPrimary;
                @Primary.canceled -= m_Wrapper.m_AttacksActionsCallbackInterface.OnPrimary;
            }
            m_Wrapper.m_AttacksActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Primary.started += instance.OnPrimary;
                @Primary.performed += instance.OnPrimary;
                @Primary.canceled += instance.OnPrimary;
            }
        }
    }
    public AttacksActions @Attacks => new AttacksActions(this);

    // Mouse
    private readonly InputActionMap m_Mouse;
    private IMouseActions m_MouseActionsCallbackInterface;
    private readonly InputAction m_Mouse_Pos;
    private readonly InputAction m_Mouse_Delta;
    public struct MouseActions
    {
        private @PlayerInput m_Wrapper;
        public MouseActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Pos => m_Wrapper.m_Mouse_Pos;
        public InputAction @Delta => m_Wrapper.m_Mouse_Delta;
        public InputActionMap Get() { return m_Wrapper.m_Mouse; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MouseActions set) { return set.Get(); }
        public void SetCallbacks(IMouseActions instance)
        {
            if (m_Wrapper.m_MouseActionsCallbackInterface != null)
            {
                @Pos.started -= m_Wrapper.m_MouseActionsCallbackInterface.OnPos;
                @Pos.performed -= m_Wrapper.m_MouseActionsCallbackInterface.OnPos;
                @Pos.canceled -= m_Wrapper.m_MouseActionsCallbackInterface.OnPos;
                @Delta.started -= m_Wrapper.m_MouseActionsCallbackInterface.OnDelta;
                @Delta.performed -= m_Wrapper.m_MouseActionsCallbackInterface.OnDelta;
                @Delta.canceled -= m_Wrapper.m_MouseActionsCallbackInterface.OnDelta;
            }
            m_Wrapper.m_MouseActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Pos.started += instance.OnPos;
                @Pos.performed += instance.OnPos;
                @Pos.canceled += instance.OnPos;
                @Delta.started += instance.OnDelta;
                @Delta.performed += instance.OnDelta;
                @Delta.canceled += instance.OnDelta;
            }
        }
    }
    public MouseActions @Mouse => new MouseActions(this);
    private int m_PCSchemeIndex = -1;
    public InputControlScheme PCScheme
    {
        get
        {
            if (m_PCSchemeIndex == -1) m_PCSchemeIndex = asset.FindControlSchemeIndex("PC");
            return asset.controlSchemes[m_PCSchemeIndex];
        }
    }
    public interface IMovementActions
    {
        void OnMove(InputAction.CallbackContext context);
    }
    public interface IAttacksActions
    {
        void OnPrimary(InputAction.CallbackContext context);
    }
    public interface IMouseActions
    {
        void OnPos(InputAction.CallbackContext context);
        void OnDelta(InputAction.CallbackContext context);
    }
}
