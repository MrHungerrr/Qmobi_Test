
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Game.Objects
{
    [RequireComponent(typeof(SpawnSpace))]
    public abstract class Factory : MonoBehaviour
    #region IInitialization
#if UNITY_EDITOR
        , IInitialization
#endif
    #endregion
    {
        [SerializeField] protected SpawnSpace _spawnSpace;


        #region Initializatior
#if UNITY_EDITOR
        public bool AutoInitializate => true;

        public void Initializate()
        {
            _spawnSpace = GetComponent<SpawnSpace>();

            if (_spawnSpace == null)
                throw new System.Exception("Отсутсвует Spawner В Factory");
        }
#endif
        #endregion

        public abstract GameObject Create();
    }
}
