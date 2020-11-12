using System;
using System.Collections.Generic;
using UnityEngine;
using Vkimow.Unity.Tools.Single;
using Game.Main;

namespace Game.Ship
{
    class ShipMoveController : MonoBehaviour
    #region IInitialization
#if UNITY_EDITOR
        , IInitialization
#endif
    #endregion
    {
        private bool _moveInput;
        private float _rotateInput;

        private float _currentAngle;

        [SerializeField] private Rigidbody2D _rb;
        [SerializeField] private float _moveSpeed;
        [SerializeField] private float _rotateSpeed;

        #region Initializatior
#if UNITY_EDITOR
        public bool AutoInitializate => true;

        public void Initializate()
        {
            _rb = GetComponent<Rigidbody2D>();
        }
#endif
        #endregion

        public void Setup()
        {
            InputManager.Instance.ShipMove += ctx => _moveInput = ctx;
            InputManager.Instance.ShipRotate += rotate => _rotateInput = rotate;
        }

        public void MyFixUpdate()
        {
            Rotate();
            Move();
        }

        private void Move()
        {
            if (_moveInput)
            {
                _rb.AddForce(_rb.transform.up * _moveSpeed * Time.fixedDeltaTime);
            }
        }

        private void Rotate()
        {
            if (_rotateInput == 0)
                return;

            _currentAngle -= _rotateInput * _rotateSpeed * Time.fixedDeltaTime;
            _rb.MoveRotation(_currentAngle);
        }
    }
}

