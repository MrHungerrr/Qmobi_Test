using Game.Main;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vkimow.Tools.Single;

public class InputManager : Singleton<InputManager>
{
    public enum GameplayType
    {
        Ship,
        Menu,
        Disable
    }

    public event Action<bool> ShipMove;
    public event Action<float> ShipRotate;


    private PlayerInput _controls;
    private GameplayType _gameplayType;


    public void Setup()
    {
        _controls = new PlayerInput();

        _controls.Ship.Movement.started += ctx => ShipMove.Invoke(true);
        _controls.Ship.Movement.started += ctx => Debug.Log("Start Move");
        _controls.Ship.Movement.canceled += ctx => ShipMove.Invoke(false);
        _controls.Ship.Movement.canceled += ctx => Debug.Log("Stop Move");
        _controls.Ship.Rotation.performed += ctx => ShipRotate.Invoke(ctx.ReadValue<float>());
        _controls.Ship.Rotation.canceled += ctx => ShipRotate.Invoke(0);

        _controls.Ship.Enable();
    }

    public void SwitchGameplayType(GameplayType type)
    {
        if (_gameplayType == type)
            return;

        _controls.Ship.Disable();
        _controls.Menu.Disable();

        switch (type)
        {
            case GameplayType.Ship:
                {
                    _controls.Ship.Enable();
                    break;
                }
            case GameplayType.Menu:
                {
                    _controls.Menu.Enable();
                    break;
                }
            case GameplayType.Disable:
                {
                    break;
                }
            default:
                {
                    Debug.Log("<color=red>Input Manager</color> Не правильно введен тип управления");
                    break;
                }
        }

        Debug.Log("Есс");

        _gameplayType = type;
    }
}
