using UnityEngine;

public class Map : MonoBehaviour {

    public float zoomedIn, zoomedOut;
    [SerializeField]
    Follow follow;
    bool isZoomedIn;

    void Start() {
        zoomedIn = Camera.main.orthographicSize;
        isZoomedIn = true;
    }

    void Update() {
        if (Input.GetKeyDown(KeyCode.M)) {
            Zoom();
        }
    }

    void Zoom() {
        Camera.main.orthographicSize = isZoomedIn ? zoomedOut : zoomedIn;
        isZoomedIn = !isZoomedIn;
        follow.isFollowing = !follow.isFollowing;
    }
}
