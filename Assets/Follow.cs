using UnityEngine;
using System.Collections;

public class Follow : MonoBehaviour {

    public Transform target;
    Transform tr;
    float zOffSet;

    void Awake() {
        tr = GetComponent<Transform>();
    }

    void FixedUpdate() {

        tr.position = new Vector3(target.position.x, target.position.y, tr.position.z);

    }
}
