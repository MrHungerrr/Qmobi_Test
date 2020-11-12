// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Game/Input/PlayerInput.inputactions'

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
            ""name"": ""Game"",
            ""id"": ""d6f0ffaf-143a-4cf7-b996-255599c1da1b"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Button"",
                    ""id"": ""7f7eeced-3a6f-42fb-8d6c-5f5d3d166c48"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Rotation"",
                    ""type"": ""Value"",
                    ""id"": ""fbf6d7e8-d8d7-4bcf-84cd-3b8848e001b1"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Fire"",
                    ""type"": ""Button"",
                    ""id"": ""dc531bac-c838-4ba7-bc73-7ca61f3c720a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""890c4791-5dac-4765-86df-cc779d6add68"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Restart"",
                    ""type"": ""Button"",
                    ""id"": ""c45a2c5e-936a-4c67-8c1f-3e382585abe6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""03aca76e-e8ca-4925-847f-b85c87b8d63e"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotation"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""862a5dda-35dd-4ba8-b871-bea8e0dd10f0"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""76c56299-dac2-4afc-9e8d-531960e511ac"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Arrows"",
                    ""id"": ""4e8a4b1c-53b1-429c-8b71-1a20a32201fa"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotation"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""aedb04e8-7740-4923-947c-2c87c5378aea"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""03c4af7c-6441-4cc6-a5f5-fa329373ace4"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""66c1139c-78e5-49cc-8770-e7e2374d366d"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6f129ad0-9321-4b37-998b-bb6882d2349a"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f49cfac8-53d6-4350-9fd0-5444897aceca"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""92c905ea-2f19-446a-b83e-aaa0f19403db"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f131b6af-e0c5-4809-896a-d21e86dce5e9"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d762952d-8128-44bf-a71f-fe80b40096b2"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Restart"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Pause"",
            ""id"": ""3596992a-51b9-43ea-ac08-908e48b618f6"",
            ""actions"": [
                {
                    ""name"": ""Resume"",
                    ""type"": ""Button"",
                    ""id"": ""17c5370d-1c25-422a-9a28-a345d190776c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Exit"",
                    ""type"": ""Button"",
                    ""id"": ""96f068c6-fbf1-4ee5-81fc-cb848506c380"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""637a96bb-b53a-4152-8bc4-9d02228f5cbe"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Exit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d1f0590d-f12c-4fab-8eee-f15416f62ad0"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Resume"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""df113fc8-9149-4817-add4-650bb13e1066"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Resume"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""71700e0b-3231-4389-aa4f-8d7976276284"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Resume"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Game Over"",
            ""id"": ""a8d9cd2f-82c2-4782-ba4e-163a49ff21b7"",
            ""actions"": [
                {
                    ""name"": ""Restart"",
                    ""type"": ""Button"",
                    ""id"": ""274449e2-91da-4a6f-81d9-7e3c8c3d0b26"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Exit"",
                    ""type"": ""Button"",
                    ""id"": ""aceb52c7-0076-49c8-9af1-5bbc4f1718e2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""b3a18131-29c7-48a8-88e0-7b2cafb2640c"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Restart"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7ca344fa-325a-41d3-8c37-582da0c6a5e9"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Restart"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1fcae636-59a8-442a-ada5-c797277aa9a2"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Exit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Game
        m_Game = asset.FindActionMap("Game", throwIfNotFound: true);
        m_Game_Movement = m_Game.FindAction("Movement", throwIfNotFound: true);
        m_Game_Rotation = m_Game.FindAction("Rotation", throwIfNotFound: true);
        m_Game_Fire = m_Game.FindAction("Fire", throwIfNotFound: true);
        m_Game_Pause = m_Game.FindAction("Pause", throwIfNotFound: true);
        m_Game_Restart = m_Game.FindAction("Restart", throwIfNotFound: true);
        // Pause
        m_Pause = asset.FindActionMap("Pause", throwIfNotFound: true);
        m_Pause_Resume = m_Pause.FindAction("Resume", throwIfNotFound: true);
        m_Pause_Exit = m_Pause.FindAction("Exit", throwIfNotFound: true);
        // Game Over
        m_GameOver = asset.FindActionMap("Game Over", throwIfNotFound: true);
        m_GameOver_Restart = m_GameOver.FindAction("Restart", throwIfNotFound: true);
        m_GameOver_Exit = m_GameOver.FindAction("Exit", throwIfNotFound: true);
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

    // Game
    private readonly InputActionMap m_Game;
    private IGameActions m_GameActionsCallbackInterface;
    private readonly InputAction m_Game_Movement;
    private readonly InputAction m_Game_Rotation;
    private readonly InputAction m_Game_Fire;
    private readonly InputAction m_Game_Pause;
    private readonly InputAction m_Game_Restart;
    public struct GameActions
    {
        private @PlayerInput m_Wrapper;
        public GameActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Game_Movement;
        public InputAction @Rotation => m_Wrapper.m_Game_Rotation;
        public InputAction @Fire => m_Wrapper.m_Game_Fire;
        public InputAction @Pause => m_Wrapper.m_Game_Pause;
        public InputAction @Restart => m_Wrapper.m_Game_Restart;
        public InputActionMap Get() { return m_Wrapper.m_Game; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameActions set) { return set.Get(); }
        public void SetCallbacks(IGameActions instance)
        {
            if (m_Wrapper.m_GameActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_GameActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_GameActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_GameActionsCallbackInterface.OnMovement;
                @Rotation.started -= m_Wrapper.m_GameActionsCallbackInterface.OnRotation;
                @Rotation.performed -= m_Wrapper.m_GameActionsCallbackInterface.OnRotation;
                @Rotation.canceled -= m_Wrapper.m_GameActionsCallbackInterface.OnRotation;
                @Fire.started -= m_Wrapper.m_GameActionsCallbackInterface.OnFire;
                @Fire.performed -= m_Wrapper.m_GameActionsCallbackInterface.OnFire;
                @Fire.canceled -= m_Wrapper.m_GameActionsCallbackInterface.OnFire;
                @Pause.started -= m_Wrapper.m_GameActionsCallbackInterface.OnPause;
                @Pause.performed -= m_Wrapper.m_GameActionsCallbackInterface.OnPause;
                @Pause.canceled -= m_Wrapper.m_GameActionsCallbackInterface.OnPause;
                @Restart.started -= m_Wrapper.m_GameActionsCallbackInterface.OnRestart;
                @Restart.performed -= m_Wrapper.m_GameActionsCallbackInterface.OnRestart;
                @Restart.canceled -= m_Wrapper.m_GameActionsCallbackInterface.OnRestart;
            }
            m_Wrapper.m_GameActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Rotation.started += instance.OnRotation;
                @Rotation.performed += instance.OnRotation;
                @Rotation.canceled += instance.OnRotation;
                @Fire.started += instance.OnFire;
                @Fire.performed += instance.OnFire;
                @Fire.canceled += instance.OnFire;
                @Pause.started += instance.OnPause;
                @Pause.performed += instance.OnPause;
                @Pause.canceled += instance.OnPause;
                @Restart.started += instance.OnRestart;
                @Restart.performed += instance.OnRestart;
                @Restart.canceled += instance.OnRestart;
            }
        }
    }
    public GameActions @Game => new GameActions(this);

    // Pause
    private readonly InputActionMap m_Pause;
    private IPauseActions m_PauseActionsCallbackInterface;
    private readonly InputAction m_Pause_Resume;
    private readonly InputAction m_Pause_Exit;
    public struct PauseActions
    {
        private @PlayerInput m_Wrapper;
        public PauseActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Resume => m_Wrapper.m_Pause_Resume;
        public InputAction @Exit => m_Wrapper.m_Pause_Exit;
        public InputActionMap Get() { return m_Wrapper.m_Pause; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PauseActions set) { return set.Get(); }
        public void SetCallbacks(IPauseActions instance)
        {
            if (m_Wrapper.m_PauseActionsCallbackInterface != null)
            {
                @Resume.started -= m_Wrapper.m_PauseActionsCallbackInterface.OnResume;
                @Resume.performed -= m_Wrapper.m_PauseActionsCallbackInterface.OnResume;
                @Resume.canceled -= m_Wrapper.m_PauseActionsCallbackInterface.OnResume;
                @Exit.started -= m_Wrapper.m_PauseActionsCallbackInterface.OnExit;
                @Exit.performed -= m_Wrapper.m_PauseActionsCallbackInterface.OnExit;
                @Exit.canceled -= m_Wrapper.m_PauseActionsCallbackInterface.OnExit;
            }
            m_Wrapper.m_PauseActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Resume.started += instance.OnResume;
                @Resume.performed += instance.OnResume;
                @Resume.canceled += instance.OnResume;
                @Exit.started += instance.OnExit;
                @Exit.performed += instance.OnExit;
                @Exit.canceled += instance.OnExit;
            }
        }
    }
    public PauseActions @Pause => new PauseActions(this);

    // Game Over
    private readonly InputActionMap m_GameOver;
    private IGameOverActions m_GameOverActionsCallbackInterface;
    private readonly InputAction m_GameOver_Restart;
    private readonly InputAction m_GameOver_Exit;
    public struct GameOverActions
    {
        private @PlayerInput m_Wrapper;
        public GameOverActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Restart => m_Wrapper.m_GameOver_Restart;
        public InputAction @Exit => m_Wrapper.m_GameOver_Exit;
        public InputActionMap Get() { return m_Wrapper.m_GameOver; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameOverActions set) { return set.Get(); }
        public void SetCallbacks(IGameOverActions instance)
        {
            if (m_Wrapper.m_GameOverActionsCallbackInterface != null)
            {
                @Restart.started -= m_Wrapper.m_GameOverActionsCallbackInterface.OnRestart;
                @Restart.performed -= m_Wrapper.m_GameOverActionsCallbackInterface.OnRestart;
                @Restart.canceled -= m_Wrapper.m_GameOverActionsCallbackInterface.OnRestart;
                @Exit.started -= m_Wrapper.m_GameOverActionsCallbackInterface.OnExit;
                @Exit.performed -= m_Wrapper.m_GameOverActionsCallbackInterface.OnExit;
                @Exit.canceled -= m_Wrapper.m_GameOverActionsCallbackInterface.OnExit;
            }
            m_Wrapper.m_GameOverActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Restart.started += instance.OnRestart;
                @Restart.performed += instance.OnRestart;
                @Restart.canceled += instance.OnRestart;
                @Exit.started += instance.OnExit;
                @Exit.performed += instance.OnExit;
                @Exit.canceled += instance.OnExit;
            }
        }
    }
    public GameOverActions @GameOver => new GameOverActions(this);
    public interface IGameActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnRotation(InputAction.CallbackContext context);
        void OnFire(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
        void OnRestart(InputAction.CallbackContext context);
    }
    public interface IPauseActions
    {
        void OnResume(InputAction.CallbackContext context);
        void OnExit(InputAction.CallbackContext context);
    }
    public interface IGameOverActions
    {
        void OnRestart(InputAction.CallbackContext context);
        void OnExit(InputAction.CallbackContext context);
    }
}
