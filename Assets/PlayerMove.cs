using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.Networking;

public class PlayerMove : NetworkBehaviour {

    Rigidbody2D rb;
    public float speed;
	[SyncVar] Vector2 target;
    Vector2 dir;
    public float threshold = 0.1f;

    void Awake() {
        rb = GetComponent<Rigidbody2D>();
    }

    void Start() {
        target = rb.position;
    }

	[Command]
	public void CmdSetTarget(Vector2 pos) {
		target = pos;
	}

    void Update() {

        dir = target - rb.position;
        dir.Normalize();
        dir *= speed;
    }

    void FixedUpdate() {
        if ((target - rb.position).sqrMagnitude > threshold) {
            rb.MovePosition(rb.position + dir);
        }
    }
}