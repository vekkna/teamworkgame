using UnityEngine;

public class GetTarget : MonoBehaviour {

    [SerializeField]
    PlayerMove player;

    public void OnMouseDown() {

        var pos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        player.target = Camera.main.ScreenToWorldPoint(pos);

    }
}
