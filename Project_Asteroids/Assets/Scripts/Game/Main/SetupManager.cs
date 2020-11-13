using Game.Objects.Asteroids;
using Game.Objects.Ship;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
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
            UIManager.Instance.Setup();
            GameManager.Instance.Setup();
            ShipController.Instance.Setup();
        }

        private void Start()
        {
            SceneManager.LoadScene(1);
        }

    }
}