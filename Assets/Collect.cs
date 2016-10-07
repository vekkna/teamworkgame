using UnityEngine;

public class Collect : MonoBehaviour {

    [SerializeField]
    Inventory inventory;

    void OnTriggerEnter2D(Collider2D other) {

        if (other.CompareTag("Gem")) {
            var gem = other.gameObject.GetComponent<Gem>();
            inventory.AddGem(gem);
            Destroy(other.gameObject);
        }

        else if (other.CompareTag("Lock")) {

            Lock l = other.gameObject.GetComponent<Lock>();
            l.players.Add(this);
            l.TryToUnlock(inventory.key);
        }
    }

    void OnTriggerExit2D(Collider2D other) {
        if (other.CompareTag("Lock")) {
            Lock l = other.gameObject.GetComponent<Lock>();
            if (l.players.Contains(this)) {
                l.players.Remove(this);
            }
        }
    }
}