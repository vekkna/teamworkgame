using UnityEngine;

public class Follow : MonoBehaviour {

    [SerializeField]
    Transform target;
    Transform tr;
    float zOffSet;
    internal bool isFollowing;

    void Awake() {
        tr = GetComponent<Transform>();
        isFollowing = true;
    }

    void FixedUpdate() {
        if (isFollowing) {
            tr.position = new Vector3(target.position.x, target.position.y, tr.position.z);
        }
    }
}