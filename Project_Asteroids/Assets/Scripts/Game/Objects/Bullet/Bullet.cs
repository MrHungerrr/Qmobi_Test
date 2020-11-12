using Game.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Game.Objects.Bullet
{
    class Bullet: MonoBehaviour
    {
        private void OnCollisionEnter2D(Collision2D collision)
        {
            IShootable shootable;

            if (collision.gameObject.TryGetComponent<IShootable>(out shootable))
            {
                ScoreManager.Instance.Add(shootable.Score);
                shootable.Hit();
            }

            Destroy(gameObject);
        }
    }
}
