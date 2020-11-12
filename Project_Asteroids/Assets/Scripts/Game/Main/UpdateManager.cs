using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vkimow.Unity.Tools.Single;


namespace Game.Main
{
    public class UpdateManager : MonoSingleton<UpdateManager>
    {
        public event Action OnUpdate;
        public event Action OnFixUpdate;

        private void Update()
        {
            OnUpdate?.Invoke();
        }

        private void FixedUpdate()
        {
            OnFixUpdate?.Invoke();
        }
    }
}
