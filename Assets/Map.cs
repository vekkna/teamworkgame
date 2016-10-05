using UnityEngine;
using System.Collections;

public class Map : MonoBehaviour {

    public float zoomedIn, zoomedOut;
    bool isZoomedIn;

    // Use this for initialization
    void Start() {
        zoomedIn = Camera.main.orthographicSize;
        isZoomedIn = true;
    }

    void Update() {
        if (Input.GetKeyDown(KeyCode.M)) {
            Zoom();
        }
    }


    public void Zoom() {
        Camera.main.orthographicSize = isZoomedIn ? zoomedOut : zoomedIn;
        isZoomedIn = !isZoomedIn;
    }
}
