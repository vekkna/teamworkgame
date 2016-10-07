using UnityEngine;
using System.Collections.Generic;

public class Inventory : MonoBehaviour {

    public int capacity = 3;

    public InventoryItem gem0, gem1, gem2, key;
    internal InventoryItem[] inventoryGems;

    List<Gem> gems;

    void Awake() {
        inventoryGems = new InventoryItem[] { gem0, gem1, gem2 };
        gems = new List<Gem>();
    }

    void OnEnable() {
        Lock.UnlockedLock += HideKey;
    }

    void OnDisable() {
        Lock.UnlockedLock -= HideKey;
    }

    public void AddGem(Gem gem) {
        if (gems.Count < capacity) {
            inventoryGems[gems.Count].Show(gem);
            gems.Add(gem);
            if (gems.Count == 3) {
                if (gems.TrueForAll((g) => g.ingredient == gems[0].ingredient)) {
                    ShowKey(gem);
                }
            }
        }
    }

    void ShowKey(Gem gem) {
        foreach (var g in inventoryGems) {
            g.Hide();
        }
        key.Show(gem);
    }

    void HideKey() {
        key.Hide();
    }
}