using Game.Ship;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vkimow.Unity.Tools.Single;


namespace Game.Main
{
    public class SetupManager : MonoSingleton<SetupManager>
    {
        private void Awake()
        {
            Setup();
        }

        private void Setup()
        {
            InputManager.Instance.Setup();
            ShipController.Instance.Setup();
        }
    }
}