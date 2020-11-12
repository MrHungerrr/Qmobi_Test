using Game.Main;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using UnityEngine;
using Vkimow.Tools.Single;

public class InputManager : Singleton<InputManager>
{
    #region Events

    #region Game Events
    public event Action<bool> ShipMove;
    public event Action<float> ShipRotate;
    public event Action<bool> ShipFire;
    public event Action GamePause;
    public event Action GameRestart;
    #endregion

    #region Pause Events
    public event Action PauseExit;
    public event Action PauseResume;
    #endregion

    #region GameOver Events
    public event Action GameOverExit;
    public event Action GameOverRestart;
    #endregion

    #endregion

    private PlayerInput _controls;


    public InputManager()
    {
        _controls = new PlayerInput();

        #region Game
        _controls.Game.Movement.started += ctx => ShipMove.Invoke(true);
        _controls.Game.Movement.canceled += ctx => ShipMove.Invoke(false);
        _controls.Game.Rotation.performed += ctx => ShipRotate.Invoke(ctx.ReadValue<float>());
        _controls.Game.Rotation.canceled += ctx => ShipRotate.Invoke(0);
        _controls.Game.Fire.started += ctx => ShipFire.Invoke(true);
        _controls.Game.Fire.canceled += ctx => ShipFire.Invoke(false);
        _controls.Game.Pause.started += ctx => GamePause.Invoke();
        _controls.Game.Restart.started += ctx => GameRestart.Invoke();
        #endregion

        #region Pause
        _controls.Pause.Exit.started += ctx => PauseExit.Invoke();
        _controls.Pause.Resume.started += ctx => PauseResume.Invoke();
        #endregion

        #region Game Over
        _controls.GameOver.Restart.started += ctx => GameOverRestart.Invoke();
        _controls.GameOver.Exit.started += ctx => GameOverExit.Invoke();
        #endregion

        GameManager.Instance.OnGameStateChanged += SwitchInputType;
    }

    private void SwitchInputType(GameManager.GameState type)
    {
        _controls.Game.Disable();
        _controls.Pause.Disable();
        _controls.GameOver.Disable();

        switch (type)
        {
            case GameManager.GameState.Game:
                {
                    _controls.Game.Enable();
                    break;
                }
            case GameManager.GameState.Pause:
                {
                    _controls.Pause.Enable();
                    break;
                }
            case GameManager.GameState.GameOver:
                {
                    _controls.GameOver.Enable();
                    break;
                }
            default:
                {
                    Debug.Log("<color=red>Input Manager</color> Не правильно введен тип управления");
                    break;
                }
        }
    }
}
