using UnityEngine;

namespace Utilities
{
    public class MonoSingletonAuto<T> : MonoBehaviour where T : MonoBehaviour
    {
        private static T instance;

        public static T Instance
        {
            get
            {
                if (instance == null)
                {
                    var go = new GameObject();
                    instance = go.AddComponent<T>();
                }

                return instance;
            }
        }
    }
}