using System;
using System.Collections.Generic;
using UnityEngine;
using Vkimow.Unity.Tools.Single;
using Game.Main;

namespace Game.Objects.Ship
{
    class ShipMoveController : MonoBehaviour
    #region IInitialization
#if UNITY_EDITOR
        , IInitialization
#endif
    #endregion
    {
        private bool _isMoving;
        private float _rotateInput;

        private const float MOVE_SPEED = 1200f;
        private const float ROTATE_SPEED = 200f;

        [SerializeField] private Rigidbody2D _rb;


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
            InputManager.Instance.ShipMove += move => _isMoving = move;
            InputManager.Instance.ShipRotate += rotate => _rotateInput = rotate;
        }

        public void MyFixUpdate()
        {
            Rotate();
            Move();
        }

        private void Move()
        {
            if (!_isMoving)
                return;

            _rb.AddForce(_rb.transform.up * MOVE_SPEED * Time.fixedDeltaTime);
        }

        private void Rotate()
        {
            if (_rotateInput == 0)
                return;

            float currentAngle = _rb.rotation;
            currentAngle -= _rotateInput * ROTATE_SPEED * Time.fixedDeltaTime;
            _rb.MoveRotation(currentAngle);
        }
    }
}

