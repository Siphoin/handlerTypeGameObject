using UnityEngine;
using System;

namespace Extensions.GameObject
{
    public static class GameObjectTypeHandler 
    {
         public static void HandleComponent<T>(this GameObject gameObject, Action<T> handler) 
         {
            var component = gameObject.GetComponent<T>();

            if (component != null) 
            {
                handler?.Invoke(component);
            }
         }
    }
}
