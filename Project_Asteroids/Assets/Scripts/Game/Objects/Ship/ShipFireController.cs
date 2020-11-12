using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vkimow.Unity.Tools.Search;

namespace Game.Objects.Ship
{
    public class ShipFireController : MonoBehaviour
    #region IInitialization
#if UNITY_EDITOR
        , IInitialization
#endif
    #endregion
    {
        private bool _isFire;
        private float _timeToFire;

        private const float FIRE_CD = 0.25f;
        private const float BULLET_SPEED = 150f;

        [SerializeField] private Transform _firePoint;
        [SerializeField] private GameObject _bulletReference;




        #region Initializatior
#if UNITY_EDITOR
        public bool AutoInitializate => true;

        public void Initializate()
        {
            _firePoint = SIC.Component(transform, "Fire Point");

            if (_firePoint == null)
                throw new Exception("Отсутсвует FirePoint в ShipFireController");

            if (_bulletReference == null)
                throw new Exception("Отсутсвует Bullet в ShipFireController");
        }
#endif
        #endregion


        public void Setup()
        {
            InputManager.Instance.ShipFire += fire => _isFire = fire;
        }


        public void MyUpdate()
        {
            if (_timeToFire > 0)
            {
                _timeToFire -= Time.deltaTime;
                return;
            }

            if (_isFire)
            {
                Fire();
                _timeToFire = FIRE_CD;
            }
        }

        private void Fire()
        {
            var bullet = GameObject.Instantiate(_bulletReference, _firePoint.position, _firePoint.rotation);
            bullet.GetComponent<Rigidbody2D>().AddForce(bullet.transform.up * BULLET_SPEED, ForceMode2D.Impulse);
            Destroy(bullet, 5f);
        }
    }
}