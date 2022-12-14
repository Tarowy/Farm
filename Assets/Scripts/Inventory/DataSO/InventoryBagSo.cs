using System.Collections.Generic;
using UnityEngine;
using Utilities;

namespace Inventory.DataSO
{
    [CreateAssetMenu(menuName = "Inventory/InventoryBag", fileName = "New Bag")]
    public class InventoryBagSo : ScriptableObject
    {
        public List<InventoryItem> inventoryItems;

        public InventoryItem GetInventoryItem(int id)
            => inventoryItems.Find(i => i.itemId == id);
    }
}