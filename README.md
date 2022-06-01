# handler Type GameObject
## Handler for checking an object for its essence. It is a replacement for checking an object through a tag. Eliminates errors in which errors may occur when changing tags. Is an extension for GameObject


`` C#
using UnityEngine;
using System;

namespace Extensions.GameObject
{
    private static class GameObjectTypeHandler 
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
``

### Example

`` C#
   gameObject.HandleComponent<Enemy>(component) => component.Method(arguments);
``
