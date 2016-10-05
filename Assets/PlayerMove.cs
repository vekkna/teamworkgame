using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class PlayerMove : MonoBehaviour {

    Rigidbody2D rb;
    public float speed;
    internal Vector2 target;
    Vector2 dir;
    public float threshold = 0.1f;

    void Awake() {
        rb = GetComponent<Rigidbody2D>();
    }

    void Start() {
        target = rb.position;
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