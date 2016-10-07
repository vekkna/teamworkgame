using UnityEngine;
using System.Collections.Generic;
using System.Linq;
using System;

public class Lock : MonoBehaviour {

    public static event Action UnlockedLock;

    public Ingredient[] ingredients;
    public Dictionary<Ingredient, bool> lockedHalves;
    public List<Collect> players;

    void Awake() {
        lockedHalves = new Dictionary<Ingredient, bool>();
        lockedHalves.Add(ingredients[0], true);
        lockedHalves.Add(ingredients[1], true);
    }

    public void TryToUnlock(InventoryItem key) {

        if (players.Count < 2) {
            return;
        }
        if (lockedHalves.ContainsKey(key.ingredient)) {
            lockedHalves[key.ingredient] = true;
            if (lockedHalves.All((h) => h.Value == false)) {
                Unlock();
            }
        }
    }

    void Unlock() {

        Debug.Log("Unlocking");
        if (UnlockedLock != null) {
            UnlockedLock();
        }
        Destroy(gameObject);

    }
}
