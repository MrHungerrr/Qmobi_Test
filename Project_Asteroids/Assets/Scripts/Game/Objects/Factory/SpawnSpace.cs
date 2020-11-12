using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Game.Objects
{
    public class SpawnSpace : MonoBehaviour
    {   
        [Header("General")]
        [SerializeField] private Vector2 _center;
        [Header("Spawn Circle")]
        [SerializeField] private float _spawnRadius;
        [Header("No Spawn Circle")]
        [SerializeField] private float _noSpawnRadius;
        public Vector2 GetRandomSpawnPosition()
        {
            float radius = Random.Range(_noSpawnRadius, _spawnRadius);
            float angle = Random.Range(0, 360);
            Vector2 direction = new Vector2(Mathf.Cos(angle), Mathf.Sin(angle));

            return _center + direction * radius;
        }

        private void OnDrawGizmosSelected()
        {
            Gizmos.color = Color.red;
            Gizmos.DrawSphere(_center, 1f);


            Gizmos.color = Color.yellow;
            Gizmos.DrawWireSphere(_center, _noSpawnRadius);

            Gizmos.color = Color.cyan;
            Gizmos.DrawWireSphere(_center, _spawnRadius);
        }
    }
}
