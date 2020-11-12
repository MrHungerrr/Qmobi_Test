using Assets.Scripts.Game.Objects.Ship;
using Game.Main;
using System;
using System.Collections.Generic;
using UnityEngine;
using Vkimow.Unity.Tools.Single;

namespace Game.Objects.Ship
{
    class ShipController : MonoSingleton<ShipController>, IShootable
    #region IInitialization
#if UNITY_EDITOR
        , IInitialization
#endif
    #endregion
    {
        public event Action OnShipExploded;
        public ShipLifeController LifeController => _lifeController;
        int IShootable.Score => 10000;


        [SerializeField] private ShipMoveController _moveController;
        [SerializeField] private ShipFireController _fireController;
        [SerializeField] private ShipLifeController _lifeController;
        [SerializeField] private ShipSpriteController _spriteController;

        #region Initializatior
#if UNITY_EDITOR
        public bool AutoInitializate => true;

        public void Initializate()
        {
            _moveController = GetComponent<ShipMoveController>();
            _fireController = GetComponent<ShipFireController>();
            _lifeController = GetComponent<ShipLifeController>();
            _spriteController = GetComponent<ShipSpriteController>();
        }
#endif
        #endregion

        public void Setup()
        {
            _moveController.Setup();
            _fireController.Setup();
            _spriteController.Setup(this);

            UpdateManager.Instance.OnUpdate += MyUpdate;
            UpdateManager.Instance.OnFixUpdate += MyFixUpdate;
        }

        public void Reset()
        {
            transform.position = Vector2.zero;
            transform.rotation = Quaternion.Euler(0, 0, 0);

            _lifeController.Reset();
            _spriteController.Reset();
        }


        private void MyUpdate()
        {
            _fireController.MyUpdate();
        }

        private void MyFixUpdate()
        {
            _moveController.MyFixUpdate();
        }

        private void Explode()
        {
            OnShipExploded?.Invoke();
        }

        void IShootable.Hit()
        {
            LifeController.Hit();

            if (LifeController.LifeCount == 0)
                Explode();
        }
    }
}
