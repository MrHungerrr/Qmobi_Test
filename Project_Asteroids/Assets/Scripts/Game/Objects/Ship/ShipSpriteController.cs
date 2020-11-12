using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Game.Objects.Ship
{
    class ShipSpriteController : MonoBehaviour
    #region IInitialization
#if UNITY_EDITOR
        , IInitialization
#endif
    #endregion
    {
        [SerializeField] private SpriteRenderer _renderer;

        #region Initializatior
#if UNITY_EDITOR
        public bool AutoInitializate => true;

        public void Initializate()
        {
            if (_renderer == null)
                throw new Exception("Отсутсвует Renderer в ShipSpriteController");
        }
#endif
        #endregion

        public void Setup(ShipController ship)
        {
            ship.OnShipExploded += Explode;
            ship.LifeController.OnHit += () => StartCoroutine(Invulnerable());
        }

        public void Reset()
        {
            _renderer.enabled = true;
        }

        private void Explode()
        {
            _renderer.enabled = false;
        }


        private IEnumerator Invulnerable()
        {
            while (ShipController.Instance.LifeController.IsInvulnerable)
            {
                _renderer.color = new Color(1, 1, 1, 0.4f);
                yield return new WaitForSeconds(0.05f);
                _renderer.color = new Color(1, 1, 1, 1);
                yield return new WaitForSeconds(0.05f);
            }
        }
    }
}
