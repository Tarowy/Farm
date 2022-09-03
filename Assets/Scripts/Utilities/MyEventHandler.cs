using System;
using System.Collections.Generic;
using UnityEngine;

namespace Utilities
{
    public static class MyEventHandler
    {
        public static event Action<InventoryLocation, List<InventoryItem>, int> UpdateInventoryUI;
        public static event Action<int, Vector3> InstantiatedItemInScene;

        public static void CallUpdateInventoryUI(InventoryLocation location, List<InventoryItem> list, int index)
            => UpdateInventoryUI?.Invoke(location, list, index);

        public static void CallInstantiatedInScene(int id, Vector3 pos)
        {
            InstantiatedItemInScene?.Invoke(id, pos);
        }
    }
}