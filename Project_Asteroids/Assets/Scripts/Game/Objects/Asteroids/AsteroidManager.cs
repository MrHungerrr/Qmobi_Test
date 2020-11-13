using Game.Main;
using Game.Objects.Asteroids;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Vkimow.Unity.Tools.Single;

namespace Game.Objects.Asteroids
{
    class AsteroidManager : MonoSingleton<AsteroidManager>
    {
        public AsteroidFactory Factory => _factory;

        private int _asteroidCount;
        private float _timeToSpawn;

        [SerializeField] private AsteroidFactory _factory;
        [SerializeField] [Range(10, 100)] private int _maxAsteroidCount;
        [SerializeField] [Range(0, 1f)] private float minSpawnCD;
        [SerializeField] [Range(1f, 2f)] private float maxSpawnCD;


        public void Start()
        {
            UpdateManager.Instance.OnUpdate += MyUpdate;
            _asteroidCount = 0;
        }

        private void MyUpdate()
        {
            if (_timeToSpawn > 0)
            {
                _timeToSpawn -= Time.deltaTime;
                return;
            }

            if(_asteroidCount < _maxAsteroidCount)
            {
                var asteroid = _factory.Create().GetComponent<Asteroid>();
                asteroid.OnExplode += () => _asteroidCount--;
                _asteroidCount++;

                _timeToSpawn = Random.Range(minSpawnCD, maxSpawnCD);
            }         
        }

        private void OnDestroy()
        {
            UpdateManager.Instance.OnUpdate -= MyUpdate;
        }
    }
}
