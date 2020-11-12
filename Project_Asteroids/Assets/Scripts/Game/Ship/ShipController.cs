using Game.Main;
using System;
using System.Collections.Generic;
using UnityEngine;
using Vkimow.Unity.Tools.Single;

namespace Game.Ship
{
    class ShipController : MonoSingleton<ShipController>
    #region IInitialization
#if UNITY_EDITOR
        ,IInitialization
#endif
#endregion
    {

        [SerializeField] private ShipMoveController _moveController;


        #region Initializatior
#if UNITY_EDITOR
        public bool AutoInitializate => true;

        public void Initializate()
        {
            _moveController = GetComponent<ShipMoveController>();
        }
#endif
        #endregion

        public void Setup()
        {
            _moveController.Setup();

            UpdateManager.Instance.OnUpdate += MyUpdate;
            UpdateManager.Instance.OnFixUpdate += MyFixUpdate;
        }


        private void MyUpdate()
        {
        }

        private void MyFixUpdate()
        {
            _moveController.MyFixUpdate();
        }


    }
}
