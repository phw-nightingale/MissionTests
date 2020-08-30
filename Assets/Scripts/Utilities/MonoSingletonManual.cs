using UnityEngine;

namespace Utilities
{
    public abstract class MonoSingletonManual<T> : MonoBehaviour where T : MonoBehaviour
    {
        protected static T instance;

        public static T Instance => instance;

        public abstract void Awake();
    }
}