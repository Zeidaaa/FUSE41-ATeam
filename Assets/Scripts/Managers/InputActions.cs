//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.5.1
//     from Assets/InputActions.inputactions
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

public partial class @InputActions: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputActions"",
    ""maps"": [
        {
            ""name"": ""GameScene"",
            ""id"": ""31157780-629c-4084-8534-a56b3906ab0f"",
            ""actions"": [
                {
                    ""name"": ""Up"",
                    ""type"": ""Button"",
                    ""id"": ""d6704cd9-ce62-4600-86a0-24fef05d7d5f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Down"",
                    ""type"": ""Button"",
                    ""id"": ""1bbac964-7e21-41b4-a5f4-698080f59758"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Right"",
                    ""type"": ""Button"",
                    ""id"": ""e7b6f774-2ca2-48d0-b7d7-d63d2bb0c4da"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Left"",
                    ""type"": ""Button"",
                    ""id"": ""498ebfbd-6f19-4471-b0ec-1c1d7dc51aec"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""A"",
                    ""type"": ""Button"",
                    ""id"": ""6adf1ce1-6dc7-404f-92fc-fc21cae3460d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""e016d767-47a3-427c-bb7a-b8be5d4b6cad"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""549b91c5-beae-4ba4-bdde-87755fe94bbe"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f18d7626-18f6-40f2-aedf-1b128298b2fe"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""42ea47cc-93ac-456c-ba8c-da3d2314fe71"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c211a396-d5e8-4e26-8267-e7c0e2dd7a67"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c460f64a-4990-41c5-b6c2-12ead662f7fe"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ece81128-032a-4741-8813-d1c319bf6c76"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fc35d827-c7d7-4136-9e69-081501394ce5"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5cb550cd-910c-46d3-8ec0-56961974f203"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""A"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""aa798037-eed2-4056-89db-4923607a18fd"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""A"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""TitleScene"",
            ""id"": ""010e71e1-c2fd-4800-9bd7-9bcaddbf8009"",
            ""actions"": [
                {
                    ""name"": ""A"",
                    ""type"": ""Button"",
                    ""id"": ""852fba01-b226-414b-9339-69943720af2c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""af2095bd-30be-4405-8fb2-9541173841b8"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""A"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7bd0b48e-9948-4fac-b4a0-4d77e75d516e"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""A"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""ResultScene"",
            ""id"": ""bdcdd9fc-4266-4ffd-89a4-7d3793a3cbd0"",
            ""actions"": [
                {
                    ""name"": ""A"",
                    ""type"": ""Button"",
                    ""id"": ""0a219361-ca73-4e50-9c62-b30d5e0394b9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""B"",
                    ""type"": ""Button"",
                    ""id"": ""7fc39d88-ce7c-453e-8320-533db9a2fab7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""3c2f7c1c-0a3c-47aa-86ab-118f40c79c61"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""A"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0f4cd5be-ba7b-4064-9731-cf0f0305a2b0"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""A"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5b2b5af9-fcd1-4e97-bb0b-ff585db3db4f"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""B"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b5ec7e65-e75d-46df-bbdb-fc779d0c6aec"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""B"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""ExplanationScene"",
            ""id"": ""eeee9585-847b-4435-81cf-3f74c3e5bf3d"",
            ""actions"": [
                {
                    ""name"": ""A"",
                    ""type"": ""Button"",
                    ""id"": ""da12b982-f756-493c-932d-b0a8a57603eb"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""35add782-1b99-4f12-8a19-1977c541807b"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""A"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""68391035-0a5b-4a0c-a8f8-f7bb34e6c9c5"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""A"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // GameScene
        m_GameScene = asset.FindActionMap("GameScene", throwIfNotFound: true);
        m_GameScene_Up = m_GameScene.FindAction("Up", throwIfNotFound: true);
        m_GameScene_Down = m_GameScene.FindAction("Down", throwIfNotFound: true);
        m_GameScene_Right = m_GameScene.FindAction("Right", throwIfNotFound: true);
        m_GameScene_Left = m_GameScene.FindAction("Left", throwIfNotFound: true);
        m_GameScene_A = m_GameScene.FindAction("A", throwIfNotFound: true);
        // TitleScene
        m_TitleScene = asset.FindActionMap("TitleScene", throwIfNotFound: true);
        m_TitleScene_A = m_TitleScene.FindAction("A", throwIfNotFound: true);
        // ResultScene
        m_ResultScene = asset.FindActionMap("ResultScene", throwIfNotFound: true);
        m_ResultScene_A = m_ResultScene.FindAction("A", throwIfNotFound: true);
        m_ResultScene_B = m_ResultScene.FindAction("B", throwIfNotFound: true);
        // ExplanationScene
        m_ExplanationScene = asset.FindActionMap("ExplanationScene", throwIfNotFound: true);
        m_ExplanationScene_A = m_ExplanationScene.FindAction("A", throwIfNotFound: true);
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

    // GameScene
    private readonly InputActionMap m_GameScene;
    private List<IGameSceneActions> m_GameSceneActionsCallbackInterfaces = new List<IGameSceneActions>();
    private readonly InputAction m_GameScene_Up;
    private readonly InputAction m_GameScene_Down;
    private readonly InputAction m_GameScene_Right;
    private readonly InputAction m_GameScene_Left;
    private readonly InputAction m_GameScene_A;
    public struct GameSceneActions
    {
        private @InputActions m_Wrapper;
        public GameSceneActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Up => m_Wrapper.m_GameScene_Up;
        public InputAction @Down => m_Wrapper.m_GameScene_Down;
        public InputAction @Right => m_Wrapper.m_GameScene_Right;
        public InputAction @Left => m_Wrapper.m_GameScene_Left;
        public InputAction @A => m_Wrapper.m_GameScene_A;
        public InputActionMap Get() { return m_Wrapper.m_GameScene; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameSceneActions set) { return set.Get(); }
        public void AddCallbacks(IGameSceneActions instance)
        {
            if (instance == null || m_Wrapper.m_GameSceneActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_GameSceneActionsCallbackInterfaces.Add(instance);
            @Up.started += instance.OnUp;
            @Up.performed += instance.OnUp;
            @Up.canceled += instance.OnUp;
            @Down.started += instance.OnDown;
            @Down.performed += instance.OnDown;
            @Down.canceled += instance.OnDown;
            @Right.started += instance.OnRight;
            @Right.performed += instance.OnRight;
            @Right.canceled += instance.OnRight;
            @Left.started += instance.OnLeft;
            @Left.performed += instance.OnLeft;
            @Left.canceled += instance.OnLeft;
            @A.started += instance.OnA;
            @A.performed += instance.OnA;
            @A.canceled += instance.OnA;
        }

        private void UnregisterCallbacks(IGameSceneActions instance)
        {
            @Up.started -= instance.OnUp;
            @Up.performed -= instance.OnUp;
            @Up.canceled -= instance.OnUp;
            @Down.started -= instance.OnDown;
            @Down.performed -= instance.OnDown;
            @Down.canceled -= instance.OnDown;
            @Right.started -= instance.OnRight;
            @Right.performed -= instance.OnRight;
            @Right.canceled -= instance.OnRight;
            @Left.started -= instance.OnLeft;
            @Left.performed -= instance.OnLeft;
            @Left.canceled -= instance.OnLeft;
            @A.started -= instance.OnA;
            @A.performed -= instance.OnA;
            @A.canceled -= instance.OnA;
        }

        public void RemoveCallbacks(IGameSceneActions instance)
        {
            if (m_Wrapper.m_GameSceneActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IGameSceneActions instance)
        {
            foreach (var item in m_Wrapper.m_GameSceneActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_GameSceneActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public GameSceneActions @GameScene => new GameSceneActions(this);

    // TitleScene
    private readonly InputActionMap m_TitleScene;
    private List<ITitleSceneActions> m_TitleSceneActionsCallbackInterfaces = new List<ITitleSceneActions>();
    private readonly InputAction m_TitleScene_A;
    public struct TitleSceneActions
    {
        private @InputActions m_Wrapper;
        public TitleSceneActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @A => m_Wrapper.m_TitleScene_A;
        public InputActionMap Get() { return m_Wrapper.m_TitleScene; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(TitleSceneActions set) { return set.Get(); }
        public void AddCallbacks(ITitleSceneActions instance)
        {
            if (instance == null || m_Wrapper.m_TitleSceneActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_TitleSceneActionsCallbackInterfaces.Add(instance);
            @A.started += instance.OnA;
            @A.performed += instance.OnA;
            @A.canceled += instance.OnA;
        }

        private void UnregisterCallbacks(ITitleSceneActions instance)
        {
            @A.started -= instance.OnA;
            @A.performed -= instance.OnA;
            @A.canceled -= instance.OnA;
        }

        public void RemoveCallbacks(ITitleSceneActions instance)
        {
            if (m_Wrapper.m_TitleSceneActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(ITitleSceneActions instance)
        {
            foreach (var item in m_Wrapper.m_TitleSceneActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_TitleSceneActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public TitleSceneActions @TitleScene => new TitleSceneActions(this);

    // ResultScene
    private readonly InputActionMap m_ResultScene;
    private List<IResultSceneActions> m_ResultSceneActionsCallbackInterfaces = new List<IResultSceneActions>();
    private readonly InputAction m_ResultScene_A;
    private readonly InputAction m_ResultScene_B;
    public struct ResultSceneActions
    {
        private @InputActions m_Wrapper;
        public ResultSceneActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @A => m_Wrapper.m_ResultScene_A;
        public InputAction @B => m_Wrapper.m_ResultScene_B;
        public InputActionMap Get() { return m_Wrapper.m_ResultScene; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ResultSceneActions set) { return set.Get(); }
        public void AddCallbacks(IResultSceneActions instance)
        {
            if (instance == null || m_Wrapper.m_ResultSceneActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_ResultSceneActionsCallbackInterfaces.Add(instance);
            @A.started += instance.OnA;
            @A.performed += instance.OnA;
            @A.canceled += instance.OnA;
            @B.started += instance.OnB;
            @B.performed += instance.OnB;
            @B.canceled += instance.OnB;
        }

        private void UnregisterCallbacks(IResultSceneActions instance)
        {
            @A.started -= instance.OnA;
            @A.performed -= instance.OnA;
            @A.canceled -= instance.OnA;
            @B.started -= instance.OnB;
            @B.performed -= instance.OnB;
            @B.canceled -= instance.OnB;
        }

        public void RemoveCallbacks(IResultSceneActions instance)
        {
            if (m_Wrapper.m_ResultSceneActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IResultSceneActions instance)
        {
            foreach (var item in m_Wrapper.m_ResultSceneActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_ResultSceneActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public ResultSceneActions @ResultScene => new ResultSceneActions(this);

    // ExplanationScene
    private readonly InputActionMap m_ExplanationScene;
    private List<IExplanationSceneActions> m_ExplanationSceneActionsCallbackInterfaces = new List<IExplanationSceneActions>();
    private readonly InputAction m_ExplanationScene_A;
    public struct ExplanationSceneActions
    {
        private @InputActions m_Wrapper;
        public ExplanationSceneActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @A => m_Wrapper.m_ExplanationScene_A;
        public InputActionMap Get() { return m_Wrapper.m_ExplanationScene; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ExplanationSceneActions set) { return set.Get(); }
        public void AddCallbacks(IExplanationSceneActions instance)
        {
            if (instance == null || m_Wrapper.m_ExplanationSceneActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_ExplanationSceneActionsCallbackInterfaces.Add(instance);
            @A.started += instance.OnA;
            @A.performed += instance.OnA;
            @A.canceled += instance.OnA;
        }

        private void UnregisterCallbacks(IExplanationSceneActions instance)
        {
            @A.started -= instance.OnA;
            @A.performed -= instance.OnA;
            @A.canceled -= instance.OnA;
        }

        public void RemoveCallbacks(IExplanationSceneActions instance)
        {
            if (m_Wrapper.m_ExplanationSceneActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IExplanationSceneActions instance)
        {
            foreach (var item in m_Wrapper.m_ExplanationSceneActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_ExplanationSceneActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public ExplanationSceneActions @ExplanationScene => new ExplanationSceneActions(this);
    public interface IGameSceneActions
    {
        void OnUp(InputAction.CallbackContext context);
        void OnDown(InputAction.CallbackContext context);
        void OnRight(InputAction.CallbackContext context);
        void OnLeft(InputAction.CallbackContext context);
        void OnA(InputAction.CallbackContext context);
    }
    public interface ITitleSceneActions
    {
        void OnA(InputAction.CallbackContext context);
    }
    public interface IResultSceneActions
    {
        void OnA(InputAction.CallbackContext context);
        void OnB(InputAction.CallbackContext context);
    }
    public interface IExplanationSceneActions
    {
        void OnA(InputAction.CallbackContext context);
    }
}
