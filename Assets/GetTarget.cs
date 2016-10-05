using UnityEngine;

public class GetTarget : MonoBehaviour {

    [SerializeField]
    PlayerMove player;

    public void OnMouseDown() {
		if (Camera.main.GetComponent<Follow> ().target != null) {
			var pos = new Vector2 (Input.mousePosition.x, Input.mousePosition.y);
			player = Camera.main.GetComponent<Follow> ().target.gameObject.GetComponent<PlayerMove> ();
			// tell server to set player target instead, then it'll be set on all hosts
			player.CmdSetTarget (Camera.main.ScreenToWorldPoint (pos));
		}
    }
}
