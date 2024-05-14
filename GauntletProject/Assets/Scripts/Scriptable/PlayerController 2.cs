//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.6.3
//     from Assets/Scripts/Scriptable/PlayerController 2.inputactions
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

public partial class @PlayerController2: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerController2()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerController 2"",
    ""maps"": [
        {
            ""name"": ""Movement"",
            ""id"": ""fe9dbc14-048e-4109-a8ee-8a827cd318f0"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""cdbcf6f0-477b-4735-b394-bf28799d3b83"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""a9cad35f-0ac9-4d7b-adc9-5d833bdeaa89"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""RotateTopLeft"",
                    ""type"": ""Button"",
                    ""id"": ""5201a3b3-ba2b-4f6b-8c2f-d312b3e25ae4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""RotateTopRight"",
                    ""type"": ""Button"",
                    ""id"": ""89426b6e-c6c3-46d5-a2e4-0351ccb41246"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""RotateBottomLeft"",
                    ""type"": ""Button"",
                    ""id"": ""58429e19-93db-4d4e-8280-5305e4711e59"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""RotateBottomRight"",
                    ""type"": ""Button"",
                    ""id"": ""11b1bcf5-97c3-4792-9ec2-2689782f9e6b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""UsePotion"",
                    ""type"": ""Button"",
                    ""id"": ""f2117c52-1612-48f0-b5a6-325713337791"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Move"",
                    ""id"": ""0a639443-26d2-4c47-93a8-e5e92c138687"",
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
                    ""id"": ""a390cdf3-af0c-40d4-b747-d52b3d0d68c3"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""7cebb8c3-5e11-4ab8-9530-6232cbe6512f"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""3d172e73-33fb-450e-a9c2-959fd68c8067"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""26b0b13b-9f97-4f76-9dd6-f7fdd8fc0f43"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""One Modifier"",
                    ""id"": ""d9be2bc1-0f20-4b00-ab44-9246bc00d5c8"",
                    ""path"": ""OneModifier"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotateTopLeft"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""modifier"",
                    ""id"": ""05a95a5b-6488-40ed-b288-fef7709514b0"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotateTopLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""binding"",
                    ""id"": ""67ab0af2-bb30-4c08-a18c-76a08a857cdf"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotateTopLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""One Modifier"",
                    ""id"": ""26fc8155-1be9-4aa2-81df-774395d86ef4"",
                    ""path"": ""OneModifier"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotateTopRight"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""modifier"",
                    ""id"": ""8e3c4df4-0e82-4cbf-905c-afbbec9611d6"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotateTopRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""binding"",
                    ""id"": ""8d8f4b43-e68e-4c5b-a534-09284ba8c5db"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotateTopRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""One Modifier"",
                    ""id"": ""cc3a2f85-e4fb-4167-a4e9-3ecd76fff354"",
                    ""path"": ""OneModifier"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotateBottomLeft"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""modifier"",
                    ""id"": ""af37a8f3-0916-429c-bea2-7f6af8f6ef83"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotateBottomLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""binding"",
                    ""id"": ""1322eebe-215e-42a9-8bd0-91b5494acbd8"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotateBottomLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""One Modifier"",
                    ""id"": ""ab315b3d-4249-4d7a-bb9b-5321f5f3b316"",
                    ""path"": ""OneModifier"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotateBottomRight"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""modifier"",
                    ""id"": ""04aedbe2-957c-463b-905d-ba453c16190d"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotateBottomRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""binding"",
                    ""id"": ""722c51a1-546f-4b14-b9f2-dd455f7ea6e5"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotateBottomRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""5826ebf6-2cd4-413d-995f-b5467c756ef9"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e2b46cc8-c180-44ac-a9be-992f90409cab"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""UsePotion"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Movement
        m_Movement = asset.FindActionMap("Movement", throwIfNotFound: true);
        m_Movement_Move = m_Movement.FindAction("Move", throwIfNotFound: true);
        m_Movement_Shoot = m_Movement.FindAction("Shoot", throwIfNotFound: true);
        m_Movement_RotateTopLeft = m_Movement.FindAction("RotateTopLeft", throwIfNotFound: true);
        m_Movement_RotateTopRight = m_Movement.FindAction("RotateTopRight", throwIfNotFound: true);
        m_Movement_RotateBottomLeft = m_Movement.FindAction("RotateBottomLeft", throwIfNotFound: true);
        m_Movement_RotateBottomRight = m_Movement.FindAction("RotateBottomRight", throwIfNotFound: true);
        m_Movement_UsePotion = m_Movement.FindAction("UsePotion", throwIfNotFound: true);
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

    // Movement
    private readonly InputActionMap m_Movement;
    private List<IMovementActions> m_MovementActionsCallbackInterfaces = new List<IMovementActions>();
    private readonly InputAction m_Movement_Move;
    private readonly InputAction m_Movement_Shoot;
    private readonly InputAction m_Movement_RotateTopLeft;
    private readonly InputAction m_Movement_RotateTopRight;
    private readonly InputAction m_Movement_RotateBottomLeft;
    private readonly InputAction m_Movement_RotateBottomRight;
    private readonly InputAction m_Movement_UsePotion;
    public struct MovementActions
    {
        private @PlayerController2 m_Wrapper;
        public MovementActions(@PlayerController2 wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Movement_Move;
        public InputAction @Shoot => m_Wrapper.m_Movement_Shoot;
        public InputAction @RotateTopLeft => m_Wrapper.m_Movement_RotateTopLeft;
        public InputAction @RotateTopRight => m_Wrapper.m_Movement_RotateTopRight;
        public InputAction @RotateBottomLeft => m_Wrapper.m_Movement_RotateBottomLeft;
        public InputAction @RotateBottomRight => m_Wrapper.m_Movement_RotateBottomRight;
        public InputAction @UsePotion => m_Wrapper.m_Movement_UsePotion;
        public InputActionMap Get() { return m_Wrapper.m_Movement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MovementActions set) { return set.Get(); }
        public void AddCallbacks(IMovementActions instance)
        {
            if (instance == null || m_Wrapper.m_MovementActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_MovementActionsCallbackInterfaces.Add(instance);
            @Move.started += instance.OnMove;
            @Move.performed += instance.OnMove;
            @Move.canceled += instance.OnMove;
            @Shoot.started += instance.OnShoot;
            @Shoot.performed += instance.OnShoot;
            @Shoot.canceled += instance.OnShoot;
            @RotateTopLeft.started += instance.OnRotateTopLeft;
            @RotateTopLeft.performed += instance.OnRotateTopLeft;
            @RotateTopLeft.canceled += instance.OnRotateTopLeft;
            @RotateTopRight.started += instance.OnRotateTopRight;
            @RotateTopRight.performed += instance.OnRotateTopRight;
            @RotateTopRight.canceled += instance.OnRotateTopRight;
            @RotateBottomLeft.started += instance.OnRotateBottomLeft;
            @RotateBottomLeft.performed += instance.OnRotateBottomLeft;
            @RotateBottomLeft.canceled += instance.OnRotateBottomLeft;
            @RotateBottomRight.started += instance.OnRotateBottomRight;
            @RotateBottomRight.performed += instance.OnRotateBottomRight;
            @RotateBottomRight.canceled += instance.OnRotateBottomRight;
            @UsePotion.started += instance.OnUsePotion;
            @UsePotion.performed += instance.OnUsePotion;
            @UsePotion.canceled += instance.OnUsePotion;
        }

        private void UnregisterCallbacks(IMovementActions instance)
        {
            @Move.started -= instance.OnMove;
            @Move.performed -= instance.OnMove;
            @Move.canceled -= instance.OnMove;
            @Shoot.started -= instance.OnShoot;
            @Shoot.performed -= instance.OnShoot;
            @Shoot.canceled -= instance.OnShoot;
            @RotateTopLeft.started -= instance.OnRotateTopLeft;
            @RotateTopLeft.performed -= instance.OnRotateTopLeft;
            @RotateTopLeft.canceled -= instance.OnRotateTopLeft;
            @RotateTopRight.started -= instance.OnRotateTopRight;
            @RotateTopRight.performed -= instance.OnRotateTopRight;
            @RotateTopRight.canceled -= instance.OnRotateTopRight;
            @RotateBottomLeft.started -= instance.OnRotateBottomLeft;
            @RotateBottomLeft.performed -= instance.OnRotateBottomLeft;
            @RotateBottomLeft.canceled -= instance.OnRotateBottomLeft;
            @RotateBottomRight.started -= instance.OnRotateBottomRight;
            @RotateBottomRight.performed -= instance.OnRotateBottomRight;
            @RotateBottomRight.canceled -= instance.OnRotateBottomRight;
            @UsePotion.started -= instance.OnUsePotion;
            @UsePotion.performed -= instance.OnUsePotion;
            @UsePotion.canceled -= instance.OnUsePotion;
        }

        public void RemoveCallbacks(IMovementActions instance)
        {
            if (m_Wrapper.m_MovementActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IMovementActions instance)
        {
            foreach (var item in m_Wrapper.m_MovementActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_MovementActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public MovementActions @Movement => new MovementActions(this);
    public interface IMovementActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
        void OnRotateTopLeft(InputAction.CallbackContext context);
        void OnRotateTopRight(InputAction.CallbackContext context);
        void OnRotateBottomLeft(InputAction.CallbackContext context);
        void OnRotateBottomRight(InputAction.CallbackContext context);
        void OnUsePotion(InputAction.CallbackContext context);
    }
}
