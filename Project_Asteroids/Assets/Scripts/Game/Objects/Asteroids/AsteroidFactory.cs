using Game.Main;
using System.Collections.Generic;
using UnityEngine;
using Game.Objects;
using Game.Objects.Ship;

namespace Game.Objects.Asteroids
{
    public class AsteroidFactory : Factory
    {

        [SerializeField] private GameObject _asteroidReference;
        private float _randomCoef = 0.3f;

        public override GameObject Create()
        {
            Vector2 position = _spawnSpace.GetRandomSpawnPosition();
            Vector2 direction = (Vector2)ShipController.Instance.transform.position - position;
            Vector2 perpendicular = Quaternion.Euler(0, 0, 90) * direction;

            float distance = Random.Range(-1f, 1f) * _randomCoef; 

            var asteroidObj = GameObject.Instantiate(_asteroidReference, position + perpendicular * distance, transform.rotation);
            var asteroid = asteroidObj.GetComponent<Asteroid>();
            asteroid.RandomSetup(direction);

            return asteroidObj;
        }
    }
}
