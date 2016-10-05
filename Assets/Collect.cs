using UnityEngine;
using System.Collections.Generic;
using UnityEngine.Networking;

public class Collect : NetworkBehaviour {

    [SerializeField]
    RectTransform inventory;
    [SerializeField]
    int capacity = 3;
    Sprite gem0, gem1, gem2;
    Sprite[] gemsSprites;

    List<Gem> gems;

    void Awake() {
        gems = new List<Gem>();
        gemsSprites = new Sprite[] { gem0, gem1, gem2 };
    }

    void OnTriggerEnter2D(Collider2D other) {
		if (!isServer) {
			return;
		}
        if (other.CompareTag("Gem")) {
            if (gems.Count >= capacity) {
                return;
            }
            AddGemToInventory(other.GetComponent<Gem>());
            Destroy(other.gameObject);
        }
    }
		
    void AddGemToInventory(Gem gem) {

    }
}