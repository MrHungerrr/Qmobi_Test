using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.PlayerLoop;

namespace Assets.Scripts.Game.Objects.Ship
{
    public class ShipLifeController : MonoBehaviour
    {
        private const float INVULNERABLE_TIME = 1f;

        public event Action<int> OnLifeCountChanged;
        public event Action OnHit;

        public bool IsInvulnerable { get; private set; }
        public int LifeCount
        {
            get
            {
                return _lifeCount;
            }
            private set
            {
                _lifeCount = value;
                OnLifeCountChanged?.Invoke(value);
            }
        }


        private int _lifeCount;
        private float _timeToStayInvulnerable;

        public void Reset()
        {
            LifeCount = 3;
        }

        public void Hit()
        {
            if (!IsInvulnerable)
            {
                LifeCount--;
                StartCoroutine(Invulnerability());
            }
        }

        private IEnumerator Invulnerability()
        {
            IsInvulnerable = true;
            OnHit?.Invoke();
            yield return new WaitForSeconds(2f);
            IsInvulnerable = false;
        }
    }
}
